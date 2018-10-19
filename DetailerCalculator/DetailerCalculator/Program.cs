using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetailerCalculator
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {

         // get application GUID as defined in AssemblyInfo.cs
         string appGuid =
             ((GuidAttribute)Assembly.GetExecutingAssembly().
                 GetCustomAttributes(typeof(GuidAttribute), false).
                     GetValue(0)).Value.ToString();

         // unique id for global mutex - Global prefix means it is global to the machine
         string mutexId = string.Format("Global\\{{{0}}}", appGuid);

         // Need a place to store a return value in Mutex() constructor call
         bool createdNew;

         // edited by Jeremy Wiebe to add example of setting up security for multi-user usage
         // edited by 'Marc' to work also on localized systems (don't use just "Everyone") 
         var allowEveryoneRule =
             new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid
                                                        , null)
                                , MutexRights.FullControl
                                , AccessControlType.Allow
                                );
         var securitySettings = new MutexSecurity();
         securitySettings.AddAccessRule(allowEveryoneRule);

         // edited by MasonGZhwiti to prevent race condition on security settings via VanNguyen
         using (var mutex = new Mutex(false, mutexId, out createdNew, securitySettings))
         {
            // edited by acidzombie24
            var hasHandle = false;
            try
            {
               try
               {
                  // note, you may want to time out here instead of waiting forever
                  // edited by acidzombie24
                  // mutex.WaitOne(Timeout.Infinite, false);
                  hasHandle = mutex.WaitOne(1000, false);
                  if (hasHandle == false)
                  {
                     MessageBox.Show("This application is already running. Double-click the tray icon to bring the calculator back up.");
                     throw new TimeoutException("Timeout waiting for exclusive access");
                  }
               }
               catch (AbandonedMutexException)
               {
                  // Log the fact that the mutex was abandoned in another process,
                  // it will still get acquired
                  hasHandle = true;
               }

               // Perform your work here.
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new FRMDetailerCalculator());

            }
            finally
            {
               // edited by acidzombie24, added if statement
               if (hasHandle)
                  mutex.ReleaseMutex();
            }
         }
      }
   }
}
