namespace ResourceProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            DBConnection db = new DBConnection();
            try
            {
                db.Execute();
            }
            finally
            {
                db?.Dispose();
            }
            */

            /*
            using (DBConnection db = new DBConnection())
            {
                db.Execute();
            }//db.Dispose вызывается по умолчанию в using
            */

            using DBConnection dB = new DBConnection();
            dB.Execute();// db.Dispose вызывается после выхода из метода Main полностью
        }
    }
}
