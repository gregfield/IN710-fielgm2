using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOMakeReports
{
    public class DBManager
    {
        SqlConnection bitDevConnection;
        DataGridView dataGrid;

        public DBManager(DataGridView dataGrid)
        {
            this.dataGrid = dataGrid;

            bitDevConnection = new SqlConnection();
            bitDevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;"+
                                                "Initial Catalog = IN700001_201601_FIELGM2;" + 
                                                "User ID = fielgm2;" +
                                                "Password = password;";
        }

        public void listPapersAndTutors()
        {
            String query = "SELECT dbo.tblPaper.paperCode, dbo.tblPaper.paperName, dbo.tblTutor.firstName, dbo.tblTutor.lastName, dbo.tblTutor.email " +
                "FROM dbo.tblPaper JOIN dbo.tblTutor ON dbo.tblPaper.tutorID = dbo.tblTutor.tutorID";

            readFromDb(query);
        }

        public void papersDueIn2Weeks()
        {
            DateTime dueDate = DateTime.Now.AddDays(14);
            String due = dueDate.ToString("yyyy-MM-dd");
            String query = "SELECT * FROM tblAssignment WHERE dbo.tblAssignment.dueDate <= '" + due + "'";

            readFromDb(query);
        }

        public void averageGrade()
        {
            String query = "SELECT dbo.tblPaper.paperCode, dbo.tblPaper.paperName, AVG(dbo.tblAssignment.mark) as Average FROM dbo.tblAssignment " +
                            "JOIN dbo.tblPaper ON dbo.tblAssignment.paperID = dbo.tblPaper.paperID " +
                            "WHERE dbo.tblAssignment.mark IS NOT NULL GROUP BY dbo.tblPaper.paperCode, dbo.tblPaper.paperName";

            readFromDb(query);
        }

        public void readFromDb(String query)
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();

            SqlCommand allPapersQuery = new SqlCommand();

            bitDevConnection.Open();
            allPapersQuery.Connection = bitDevConnection;
            allPapersQuery.CommandText = query;

            SqlDataReader dbReader;
            dbReader = allPapersQuery.ExecuteReader();
            dbReader.Read();

            int fieldCount = dbReader.FieldCount;

            var datacoloumns = Enumerable.Range(0, dbReader.FieldCount)
                                    .Select(dbReader.GetName)
                                    .ToList();

            foreach (var col in datacoloumns)
            {
                dataGrid.Columns.Add(col, col);
            }

            while (dbReader.Read())
            {
                string[] row = new string[dataGrid.Columns.Count];
                for (int i = 0; i < fieldCount; i++)
                {
                    row[i] = dbReader.GetValue(i).ToString();
                }
                dataGrid.Rows.Add(row);
            }

            bitDevConnection.Close();
        }
    }
}
