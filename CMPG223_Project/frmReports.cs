using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Project
{
	public partial class frmReports : Form
	{
		public frmReports()
		{
			InitializeComponent();			

			// Initial UI state
			lblPastYearCount.Text = "-";
			lblPast6MonthsCount.Text = "-";
			lblPastMonthCount.Text = "-";
			lblStatus.Text = "Ready...";

			// Set DataGridViews to read-only
			dgvTopTypes.ReadOnly = true;
			dgvLeastTypes.ReadOnly = true;
			dgvZeroTypes.ReadOnly = true;
			dgvTopTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvLeastTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvZeroTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			// Set DataGridView fonts and size
			dgvTopTypes.Font = new Font("Tahoma", 10, FontStyle.Regular);
			dgvLeastTypes.Font = new Font("Tahoma", 10, FontStyle.Regular);
			dgvZeroTypes.Font = new Font("Tahoma", 10, FontStyle.Regular);

			// Initially disable export (nothing to export)
			btnExportCsv.Enabled = false;
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			try
			{
				btnGenerate.Enabled = false;
				btnExportCsv.Enabled = false;
				lblStatus.Text = "Generating reports...";
				Application.DoEvents(); // keep UI responsive for small operations

				// Determine date ranges (client-local). Use DateTime.Now
				DateTime toDate = DateTime.Now;
				DateTime fromYear = toDate.AddYears(-1);          // past year
				DateTime from6Months = toDate.AddMonths(-6);      // past 6 months
				DateTime fromMonth = toDate.AddMonths(-1);        // past month

				GenerateTotals(fromYear, from6Months, fromMonth, toDate);
				GenerateTypeReports(fromYear, toDate);

				lblStatus.Text = "Reports generated successfully.";

				// Enable export if any of the grids contain data
				btnExportCsv.Enabled = HasAnyReportData();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Unexpected error while generating reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				lblStatus.Text = "Error generating reports.";
			}
			finally
			{
				btnGenerate.Enabled = true;
			}
		}

		private bool HasAnyReportData()
		{
			return (dgvTopTypes.DataSource != null && dgvTopTypes.Rows.Count > 0)
				|| (dgvLeastTypes.DataSource != null && dgvLeastTypes.Rows.Count > 0)
				|| (dgvZeroTypes.DataSource != null && dgvZeroTypes.Rows.Count > 0);
		}

		private void btnExportCsv_Click(object sender, EventArgs e)
		{
			try
			{
				if (!HasAnyReportData())
				{
					MessageBox.Show("There is no report data to export. Generate the reports first.", "Nothing to export", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				using (var folderDialog = new FolderBrowserDialog())
				{
					folderDialog.Description = "Select folder to save CSV report files";
					folderDialog.ShowNewFolderButton = true;
					if (folderDialog.ShowDialog() != DialogResult.OK)
						return;

					string folder = folderDialog.SelectedPath;
					btnExportCsv.Enabled = false;
					lblStatus.Text = "Exporting CSV files...";
					Application.DoEvents();

					var writtenFiles = new System.Collections.Generic.List<string>();
					string ts = DateTime.Now.ToString("yyyyMMdd_HHmmss");

					// Export Top Types
					if (dgvTopTypes.DataSource != null && dgvTopTypes.Rows.Count > 0)
					{
						string fileTop = Path.Combine(folder, $"TopTypes_{ts}.csv");
						ExportGridToCsv(dgvTopTypes, fileTop);
						writtenFiles.Add(fileTop);
					}

					// Export Least Types
					if (dgvLeastTypes.DataSource != null && dgvLeastTypes.Rows.Count > 0)
					{
						string fileLeast = Path.Combine(folder, $"LeastTypes_{ts}.csv");
						ExportGridToCsv(dgvLeastTypes, fileLeast);
						writtenFiles.Add(fileLeast);
					}

					// Export Zero Types
					if (dgvZeroTypes.DataSource != null && dgvZeroTypes.Rows.Count > 0)
					{
						string fileZero = Path.Combine(folder, $"ZeroTypes_{ts}.csv");
						ExportGridToCsv(dgvZeroTypes, fileZero);
						writtenFiles.Add(fileZero);
					}

					if (writtenFiles.Count == 0)
					{
						MessageBox.Show("No report tables had data to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
						lblStatus.Text = "Nothing exported.";
					}
					else
					{
						var sb = new StringBuilder();
						sb.AppendLine("Exported files:");
						foreach (var f in writtenFiles) sb.AppendLine(f);

						MessageBox.Show(sb.ToString(), "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
						lblStatus.Text = $"Exported {writtenFiles.Count} file(s).";
					}
				}
			}
			catch (UnauthorizedAccessException ex)
			{
				MessageBox.Show($"Permission error writing files: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				lblStatus.Text = "Export failed (permission).";
			}
			catch (IOException ex)
			{
				MessageBox.Show($"I/O error while exporting: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				lblStatus.Text = "Export failed (I/O).";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Unexpected error while exporting CSV: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				lblStatus.Text = "Export failed.";
			}
			finally
			{
				btnExportCsv.Enabled = HasAnyReportData();
			}
		}

		#region Report 1 - Totals (distinct beneficiaries)
		private void GenerateTotals(DateTime fromYear, DateTime from6Months, DateTime fromMonth, DateTime toDate)
		{
			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			{
				conn.Open();

				string sqlDistinctCount = @"
                    SELECT COUNT(DISTINCT bk.Ben_Id) 
                    FROM Booking bk
                    WHERE bk.Check_In BETWEEN @From AND @To
                ";

				using (SqlCommand cmd = new SqlCommand(sqlDistinctCount, conn))
				{
					// Past Year
					cmd.Parameters.Clear();
					cmd.Parameters.Add("@From", SqlDbType.DateTime).Value = fromYear;
					cmd.Parameters.Add("@To", SqlDbType.DateTime).Value = toDate;
					object val1 = cmd.ExecuteScalar();
					lblPastYearCount.Text = (val1 == DBNull.Value ? 0 : Convert.ToInt32(val1)).ToString();

					// Past 6 months
					cmd.Parameters.Clear();
					cmd.Parameters.Add("@From", SqlDbType.DateTime).Value = from6Months;
					cmd.Parameters.Add("@To", SqlDbType.DateTime).Value = toDate;
					object val2 = cmd.ExecuteScalar();
					lblPast6MonthsCount.Text = (val2 == DBNull.Value ? 0 : Convert.ToInt32(val2)).ToString();

					// Past month
					cmd.Parameters.Clear();
					cmd.Parameters.Add("@From", SqlDbType.DateTime).Value = fromMonth;
					cmd.Parameters.Add("@To", SqlDbType.DateTime).Value = toDate;
					object val3 = cmd.ExecuteScalar();
					lblPastMonthCount.Text = (val3 == DBNull.Value ? 0 : Convert.ToInt32(val3)).ToString();
				}
			}
		}
		#endregion

		#region Reports 2,3,4 - Beneficiary types (past year)
		private void GenerateTypeReports(DateTime fromYear, DateTime toDate)
		{
			// 1) get counts (bookings) per beneficiary type in the past year
			DataTable dtCounts = GetVisitCountsPerType(fromYear, toDate);

			// 2) Top types (max bookings)
			if (dtCounts.Rows.Count == 0)
			{
				dgvTopTypes.DataSource = null;
				dgvLeastTypes.DataSource = null;
			}
			else
			{
				// get max
				int maxCount = 0;
				foreach (DataRow r in dtCounts.Rows)
				{
					int c = Convert.ToInt32(r["VisitCount"]);
					if (c > maxCount) maxCount = c;
				}

				// select rows where VisitCount == maxCount
				DataTable dtTop = dtCounts.Clone();
				foreach (DataRow r in dtCounts.Rows)
					if (Convert.ToInt32(r["VisitCount"]) == maxCount)
						dtTop.ImportRow(r);

				dgvTopTypes.DataSource = dtTop;

				// least (minimum > 0)
				int minCount = int.MaxValue;
				foreach (DataRow r in dtCounts.Rows)
				{
					int c = Convert.ToInt32(r["VisitCount"]);
					if (c > 0 && c < minCount) minCount = c;
				}

				DataTable dtLeast = dtCounts.Clone();
				if (minCount != int.MaxValue)
				{
					foreach (DataRow r in dtCounts.Rows)
						if (Convert.ToInt32(r["VisitCount"]) == minCount)
							dtLeast.ImportRow(r);
				}
				// if no rows have visits > 0, dtLeast remains empty
				dgvLeastTypes.DataSource = dtLeast;
			}

			// 3) types with zero visits (past year)
			DataTable dtZero = GetTypesWithZeroVisits(fromYear, toDate);
			dgvZeroTypes.DataSource = dtZero;
		}

		// gets counts of bookings per Beneficiary_Type for the date range
		private DataTable GetVisitCountsPerType(DateTime from, DateTime to)
		{
			DataTable dt = new DataTable();
			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			using (SqlCommand cmd = new SqlCommand(@"
                SELECT bt.Ben_Type_Id, bt.Description, COUNT(*) AS VisitCount
                FROM Booking bk
                INNER JOIN Beneficiary b ON bk.Ben_Id = b.Ben_Id
                INNER JOIN Beneficiary_Type bt ON b.Ben_Type_Id = bt.Ben_Type_Id
                WHERE bk.Check_In BETWEEN @From AND @To
                GROUP BY bt.Ben_Type_Id, bt.Description
                ORDER BY VisitCount DESC, bt.Description
            ", conn))
			{
				cmd.Parameters.Add("@From", SqlDbType.DateTime).Value = from;
				cmd.Parameters.Add("@To", SqlDbType.DateTime).Value = to;
				using (SqlDataAdapter da = new SqlDataAdapter(cmd))
					da.Fill(dt);
			}
			return dt;
		}

		// gets beneficiary types that had ZERO bookings in the date range
		private DataTable GetTypesWithZeroVisits(DateTime from, DateTime to)
		{
			DataTable dt = new DataTable();
			using (SqlConnection conn = new SqlConnection(SharedConstants.connString))
			using (SqlCommand cmd = new SqlCommand(@"
                SELECT bt.Ben_Type_Id, bt.Description
                FROM Beneficiary_Type bt
                LEFT JOIN (
                    SELECT b.Ben_Type_Id, COUNT(*) AS VisitCount
                    FROM Booking bk
                    INNER JOIN Beneficiary b ON bk.Ben_Id = b.Ben_Id
                    WHERE bk.Check_In BETWEEN @From AND @To
                    GROUP BY b.Ben_Type_Id
                ) t ON bt.Ben_Type_Id = t.Ben_Type_Id
                WHERE ISNULL(t.VisitCount, 0) = 0
                ORDER BY bt.Description
            ", conn))
			{
				cmd.Parameters.Add("@From", SqlDbType.DateTime).Value = from;
				cmd.Parameters.Add("@To", SqlDbType.DateTime).Value = to;
				using (SqlDataAdapter da = new SqlDataAdapter(cmd))
					da.Fill(dt);
			}
			return dt;
		}
		#endregion

		#region CSV Export helper
		// Exports a DataGridView to CSV filePath. Throws exceptions upward for caller to handle.
		private void ExportGridToCsv(DataGridView dgv, string filePath)
		{
			if (dgv == null || dgv.DataSource == null || dgv.Rows.Count == 0)
				throw new InvalidOperationException("No data in grid to export.");

			var sb = new StringBuilder();

			// headers (use column header text)
			for (int i = 0; i < dgv.Columns.Count; i++)
			{
				sb.Append(EscapeCsv(dgv.Columns[i].HeaderText ?? string.Empty));
				if (i < dgv.Columns.Count - 1) sb.Append(",");
			}
			sb.AppendLine();

			// rows
			foreach (DataGridViewRow row in dgv.Rows)
			{
				if (row.IsNewRow) continue;
				for (int i = 0; i < dgv.Columns.Count; i++)
				{
					var v = row.Cells[i].Value;
					string cell = v == null ? "" : v.ToString();
					sb.Append(EscapeCsv(cell));
					if (i < dgv.Columns.Count - 1) sb.Append(",");
				}
				sb.AppendLine();
			}

			File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
		}

		private string EscapeCsv(string s)
		{
			if (s == null) return "";
			bool mustQuote = s.Contains(",") || s.Contains("\"") || s.Contains("\n") || s.Contains("\r");
			s = s.Replace("\"", "\"\"");
			return mustQuote ? $"\"{s}\"" : s;
		}
		#endregion
	}
}
