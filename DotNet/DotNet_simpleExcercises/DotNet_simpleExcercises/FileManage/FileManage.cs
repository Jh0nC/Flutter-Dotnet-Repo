namespace DotNet_simpleExcercises
{
    class FileManage
    {
        public static void ReadAllFile(String fileRoute)
        {
            String fileLine;
            // variable en donde se guardara una linea del archivo

            StreamReader sr = new StreamReader(fileRoute);
            // el stream reader, fucion que lee el archivo que se le propine

            fileLine = sr.ReadLine();
            // ReadLine() lee la primera linea del archivo

            while (fileLine != null)
            {
                Console.WriteLine(fileLine.ToUpper() + "\n");
                fileLine = sr.ReadLine();
            }
            sr.Close();
        }

        public static void WriteOnFile(String fileRoute)
        {
            StreamWriter sr = new StreamWriter(fileRoute);
            Console.WriteLine("Cantidad de nombres a ingresar: ");
            int linesToWrite = Console.Read();
            Console.WriteLine("Ingrese los nombre: ");
            for (int i = 0; i < linesToWrite; i++)
            {
            String line = Console.ReadLine();
            sr.WriteLine(line);
            }
            sr.Close();
        }

        public static void File()
        {

        }
    }
}
