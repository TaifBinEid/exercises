using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLBuilder sql = new SQLBuilder();
            SQLBuilder sq2 = new SQLBuilder();
            string sqlStatement = sql.statementSQL("SELECT")
                                     .Selection("*")
                                     .Position("FROM")
                                     .TableName("Customer")
                                     .get();
            Console.WriteLine("\n\n" + sqlStatement);


            string sqlStatementUPDATE = sq2.statementSQL("UPDATE")
                                     .Selection("Customer"+"\n")
                                     .Position("SET" + "\n")
                                     .TableName("ContactName='TAIF'")
                                     .get();
            Console.WriteLine("\n\n" + sqlStatementUPDATE);

        }
    }

    class SQLBuilder
    {
        public string statement ;

        public SQLBuilder()
        {
            this.statement = "";
        }

        public SQLBuilder statementSQL(string statement)
        {
            this.statement += statement;
            return this;
        }
        public SQLBuilder Selection(string star)
        {
            this.statement += " " + star;
            return this;
        }
        public SQLBuilder Position(string position)
        {
            this.statement +=" "+ position ;

            return this;
        }
        public SQLBuilder TableName(string name)
        {
            this.statement +=  " " +" " + name;
            return this;
        }

        public string get()
        {
            return this.statement;
        }
    }

}
