using DawHacks.Routines;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace DawHacks
{
    internal class Game
    {
        List<Routine> routines = new();
        Routine currentRoutine;
        internal bool IsGameFinished() => isFinished;
        internal bool HasQuit() => hasQuit;
        static bool isFinished;
        static bool hasQuit;
        static string nextRoutine = "";
        internal static double emission, charging, lights, car, stm, shower, clothes, screentime, toilet, lights2;

        internal void Add(Routine routine)
        {
            routines.Add(routine);
            if (currentRoutine == null)
            {
                currentRoutine = routine;
            }
        }

        internal string CurrentRoutineDescription => currentRoutine.CreateDescription();

        internal void ReceiveChoice(int choice)
        {
            currentRoutine.ReceiveChoice(choice);
            CheckTransition();
        }

        internal static void Transition<T>() where T : Routine
        {
            nextRoutine = typeof(T).Name;
        }

        internal static void Finish()
        {
            isFinished = true;
        }

        internal static void Quit()
        {
            hasQuit = true;
        }

        internal void CheckTransition()
        {
            foreach (var room in routines)
            {
                if (room.GetType().Name == nextRoutine)
                {
                    nextRoutine = "";
                    currentRoutine = room;
                    break;
                }
            }
        }
    }
}
