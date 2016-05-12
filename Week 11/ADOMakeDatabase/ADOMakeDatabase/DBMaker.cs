using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOMakeDatabase
{
    public class DBMaker
    {
        SqlConnection bitDevConnection;

        public DBMaker(String password)
        {
            bitDevConnection = new SqlConnection();
            bitDevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;"+
                                                "Initial Catalog = IN700001_201601_FIELGM2;" + 
                                                "User ID = fielgm2;" +
                                                "Password = " + password + ";";
        }

        public int makeDb()
        {
            String makeDBQuery = @"IF OBJECT_ID('tblAssignment') IS NOT NULL DROP TABLE tblAssignment
                            IF OBJECT_ID('tblPaper') IS NOT NULL DROP TABLE tblPaper  
                            IF OBJECT_ID('tblTutor') IS NOT NULL DROP TABLE tblTutor

                            CREATE TABLE tblTutor
                            (
                                tutorID   int     IDENTITY,
                                firstName    varchar(15) NOT NULL,
                                lastName     varchar(15) NOT NULL,
                                email        varchar(30) NOT NULL,

                                CONSTRAINT PK_tblTutor PRIMARY KEY(tutorID)
                            )

                            CREATE TABLE tblPaper
                            (
                                paperID				int			IDENTITY,
                                tutorID			int			NOT NULL,
                                paperCode			varchar(10)	NOT NULL,
                                paperName           varchar(15) NOT NULL,

                                CONSTRAINT PK_paperID PRIMARY KEY(paperID),
                                CONSTRAINT FP_paper_tutor FOREIGN KEY(tutorID) REFERENCES tblTutor(tutorID)
                            )
        
                            CREATE TABLE tblAssignment
                            (
                                assignmentID		int			IDENTITY,
                                paperID				int			NOT NULL,
                                assignmentname		varchar(30) NOT NULL,
                                mark			    int			NULL,
                                dueDate				date	    NOT NULL,
                                CONSTRAINT PK_assignmentID PRIMARY KEY(assignmentID),
                                CONSTRAINT FK_assignmentPaper FOREIGN KEY(paperID) REFERENCES tblPaper(paperID) 
                            )

                            INSERT INTO tblTutor VALUES('Jim','Hobbs','jhobbs@hotmail.co.nz')
                            INSERT INTO tblTutor VALUES('Steve','Franks','sfranks@gmail.com')
                            INSERT INTO tblTutor VALUES('Claire','Carey','clairec@gmail.com')
                            INSERT INTO tblTutor VALUES('Alycia','Taylor','alyctay@hotmail.cpm')
                               
                            INSERT INTO tblPaper VALUES(1,'GC38','OOSD')
                            INSERT INTO tblPaper VALUES(2,'BIT654','Mobile')
                            INSERT INTO tblPaper VALUES(3,'CD389', 'Systems Admin')
                            INSERT INTO tblPaper VALUES(4,'HF15','Project')

                            INSERT INTO tblAssignment VALUES(1,'Pong',100,'2016-05-09')
                            INSERT INTO tblAssignment VALUES(2,'Camera', '', '2016-05-23')
                            INSERT INTO tblAssignment VALUES(3,'Python','100','2016-04-12')
                            INSERT INTO tblAssignment VALUES(4,'Speech', '', '2016-06-18')";

            SqlCommand makeDBCommand = new SqlCommand();

            bitDevConnection.Open();

            makeDBCommand.Connection = bitDevConnection;

            makeDBCommand.CommandText = makeDBQuery;

            int rowsAffected = makeDBCommand.ExecuteNonQuery();

            bitDevConnection.Close();

            return rowsAffected;
        }
    }
}
