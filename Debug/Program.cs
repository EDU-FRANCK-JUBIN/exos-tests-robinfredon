using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DebugNS
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            log.Debug("Hello logging world!");
            Console.WriteLine("Hit enter");
            Console.ReadLine();

            log.Info("Hello logging world!");
            Console.WriteLine("Hit enter");
            Console.ReadLine();

            log.Warn("Hello logging world!");
            Console.WriteLine("Hit enter");
            Console.ReadLine();

            log.Error("Hello logging world!");
            Console.WriteLine("Hit enter");
            Console.ReadLine();

            log.Fatal("Hello logging world!");
            Console.WriteLine("Hit enter");
            Console.ReadLine();


            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[array1.Length + array2.Length];
            Console.WriteLine("Enter Any 5 Elements for the First Array :");
            for (int i = 0; i < 5; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Any 5 Elements for the Second Array :");
            for (int i = 0; i < 5; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            Buffer.BlockCopy(array1, 0, array3, 0, array1.Length * sizeof(int));
            Buffer.BlockCopy(array2, 0, array3, array1.Length * sizeof(int),
                             array2.Length * sizeof(int));
            Console.WriteLine("Elements in the Third Array After Appending" +
                              " First and Second Arrays :");
            foreach (int value in array3)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();



            String maVar = "Eteint";

            // on fait des traitements
            maVar = maVar.ToUpper();
            System.Console.WriteLine("maVar = " + maVar);

            // on fait des traitements
            maVar = maVar.ToLower();
            System.Console.WriteLine("maVar = " + maVar);

            // on fait des traitements
            maVar = maVar.Substring(1, 3);
            System.Console.WriteLine("maVar = " + maVar);

            // on fait des traitements
            maVar = maVar.Replace("Ete", "Hiver");
            System.Console.WriteLine("maVar = " + maVar);



            System.Diagnostics.Debug.WriteLine("^. .^");


            Debug.WriteLine("List of errors:");
            Debug.Indent();
            Debug.WriteLine("Error 1: File not found");
            Debug.WriteLine("Error 2: Directory not found");
            Debug.Unindent();
            Debug.WriteLine("End of list of errors");


            // Create an index for an array.
            int index;

            // Perform some action that sets the index.
            index = -40;

            // Test that the index value is valid. 
            //     Debug.Assert(index > -1,"TEXTE COURT","TEXTE LONG");


            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry("Log message example", EventLogEntryType.Information, 101, 1);
            }



            // EventLog.CreateEventSource("myApp", "myAppLog");
            // EventLog.WriteEntry("myApp", "Test log message", EventLogEntryType.Error);




            String LogSource = "MonLogSource";
            String LogName = "MonLogName";
            if (!EventLog.SourceExists(LogSource))
            {
                EventLog.CreateEventSource(LogSource, LogName);
            }

            // Insert into Event Log
            EventLog Log = new EventLog();
            Log.Source = LogSource;
            Log.WriteEntry("Mon message", EventLogEntryType.Error);

            System.Console.ReadLine();



            EventLog myLog = new EventLog();
            myLog.Log = "MonLogName";
            foreach (EventLogEntry entry in myLog.Entries)
            {
                Console.WriteLine("\tEntry: " + entry.Message);
            }

            System.Console.ReadLine();




            Users user = new Users("Suresh Dasari", 30);
            user.GetUserDetails();
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();

        }
    }
}
