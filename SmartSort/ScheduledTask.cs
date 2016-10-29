using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSort
{
    class ScheduledTask
    {

        public enum Repetition
        {
            Never,
            Daily,
            Weekly,
            Monthly                 
        };

        #region Properties
        public DateTime StartTime { get; set; }

        public bool RunOnBattery { get; set; }
        public Repetition Repeat { get; set; }
        public short Interval { get; set; }

        #endregion

        public ScheduledTask(DateTime _StartTime, Repetition _repeat = Repetition.Never, short _interval = 1, bool _RunOnBattery = true)
        {
            StartTime = _StartTime;
            Repeat = _repeat;
            Interval = _interval;
            RunOnBattery = _RunOnBattery;

            ScheduleTask(); 
        }
        
        private void ScheduleTask()
        {
            using (TaskService ts = new TaskService())
            {

                try
                {
                    TaskDefinition taskDef = ts.NewTask();
                    taskDef.RegistrationInfo.Description = "SmartSort sorting scheduled task";
                    taskDef.Settings.AllowHardTerminate = false;
                    taskDef.Settings.MultipleInstances = TaskInstancesPolicy.Parallel;
                    taskDef.Settings.DisallowStartIfOnBatteries = RunOnBattery;

                    switch (Repeat)
                    {
                        case Repetition.Never:
                            TimeTrigger timeTrig = (TimeTrigger)taskDef.Triggers.Add(new TimeTrigger());
                            timeTrig.StartBoundary = StartTime;
                            break;

                        case Repetition.Daily:
                            DailyTrigger dailyTrig= (DailyTrigger)taskDef.Triggers.Add(new DailyTrigger());
                            dailyTrig.DaysInterval = Interval;
                            dailyTrig.StartBoundary = StartTime;
                            break;

                        case Repetition.Weekly:
                            WeeklyTrigger weeklyTrig = (WeeklyTrigger)taskDef.Triggers.Add(new WeeklyTrigger((DaysOfTheWeek)StartTime.DayOfWeek));
                            weeklyTrig.WeeksInterval = Interval;
                            weeklyTrig.StartBoundary = StartTime;
                            break;

                        case Repetition.Monthly:
                            MonthlyTrigger monthlyTrig = (MonthlyTrigger)taskDef.Triggers.Add(new MonthlyTrigger(DateTime.DaysInMonth(StartTime.Year, StartTime.Day)));
                            monthlyTrig.StartBoundary = StartTime;
                            break;
                    }

                    // Should register the sorting.exe instead of notepad
                    taskDef.Actions.Add(new ExecAction("notepad.exe"));

                    // Register the task in the root folder
                    const string taskName = "Smart Sort";
                    ts.RootFolder.RegisterTaskDefinition(taskName, taskDef);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

            // Deletion of task for tests 
            // ts.RootFolder.DeleteTask("SmartSort");

            }
        }
    }
}
