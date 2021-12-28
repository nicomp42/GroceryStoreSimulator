/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * Demo of running the simulator without a GUI
 */
using System;
using SimulatorNamespace;

namespace ConsoleAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo();
        }
        private static void Demo()
        {
            SimulatorNamespace.SimGrocery sg = new SimulatorNamespace.SimGrocery();
            Config.randomNumberSeed = 42;
            Config.random = new Random(Config.randomNumberSeed);
            Config.verboseConsoleMode = false;
            Config.elapsedMinutesToRun = 0;     // zero means ignore this limit
            Config.setTransactionDelay(5);          // Seconds
            Config.useCurrentDateStampForTransaction = true;
            Config.startDate = DateTime.Now;
            Config.throughDate = DateTime.Now.AddYears(10);
            Config.mode = Config.modeEnum.running;
            Config.server = "il-server-002.uccc.uc.edu\\mssqlserver2019";
            Config.login = "GroceryStoreSimulatorIsaiahLogin";
            Config.password = "Plugh42!";
            Config.database = "GroceryStoreSimulatorIsaiah";
            Config.useCoupons = true;
            Config.checkForAllStoresClosed = true;
            Config.executeFailSafeOptions = false;      // false = do not delete all the history from stores, employees, etc.
            Config.prioritizeProducts = true;
            // This is tricky: the index of the selected item in the combo box must map to a specific enum. Be sure both are zero based:
            Config.storeCheckInterval = Config.enum_availableCheckIntervals.OnThe10s;
            Config.emplCheckInterval = Config.enum_availableCheckIntervals.OnThe10s;
            Config.productCheckInterval = Config.enum_availableCheckIntervals.OnThe10s;
            Config.couponCheckInterval = Config.enum_availableCheckIntervals.OnThe10s;
            //String[] tmp = cbCouponAmountToAdd.SelectedItem.ToString().Split();
            Config.couponAmountToAdd = 100; // After couponCheckInterval
            int numOfTransactionsToAdd = 0; // 0 = infinite transactions
            if (Config.executeFailSafeOptions) {
                ProductPriceHist.CopyFromFromProductTableIntoProductPriceHist(Config.startDate); // Config.earliestPossibleDate);     // Fail-safe strategy
                Empl.MakeAllEmplAvailableToWork(Config.startDate); // Config.earliestPossibleDate);                                   // Fail-safe strategy
                Store.MakeAllStoreOpenForBusiness(Config.startDate); // Config.earliestPossibleDate);                                 // Fail-safe strategy
            }
            //*****************************
            // Finally, start transacting
            //*****************************
            Utils.Log("Starting Simulator...");
            sg.StartTransactionSimulation(numOfTransactionsToAdd, Config.random, null, null);
        }
    }
}
