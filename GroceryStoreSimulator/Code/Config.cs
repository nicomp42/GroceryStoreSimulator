/*****************************************************************
 * Grocery Store Simulator
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * University of Cincinnati Clermont College
 * ***************************************************************/
using GroceryStoreSimulator.Code;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreSimulator {
    class Config {
        private static int transactionDelay = 5; // Default is 5 millisecond delay between customer transactions that are added to the database
        public static List<EmplName> emplList;
        public static string version = "1.0.6";
        public static string doubleQuote = "\"";
        private static SqlConnection mMyConnection;
        private static string mServer, mLogin, mPassword, mDatabase;
        private static bool mUseCoupons;
        private static Random mRandom;
        private static int mRandomNumberSeed;
        private static double mMaxPriceChangePct = .02;
        private static DateTime mStartDateTime = DateTime.Now;
        private static DateTime mThroughDateTime = DateTime.Now.AddYears(1);
        private static bool mUseCurrentDateStampForTransaction;
        private static DateTime mEarliestPossibleDate = DateTime.Parse("1/1/1900");     // Arbitrary.
        private static int mCouponAmountToAdd;     // How many coupons to add during a simulation check interval.
        private static Boolean mExecuteFailSafeOptions;
        private static int mElapsedMinutesToRun;
        public static List<City> cityList;

        public static int elapsedMinutesToRun
        {
            get { return mElapsedMinutesToRun; }
            set { mElapsedMinutesToRun = value; }
        }

        public static Boolean executeFailSafeOptions
        {
            get { return mExecuteFailSafeOptions; }
            set { mExecuteFailSafeOptions = value; }
        }

        public static SqlConnection myConnection
        {
            get { return mMyConnection; }
            set { mMyConnection = value;}
        }

        public static DateTime earliestPossibleDate
        {
            get {return mEarliestPossibleDate;}
            set { mEarliestPossibleDate = value; }
        }
        public enum enum_availableCheckIntervals {Never, OnTheHour, OnThe1s, OnThe5s, OnThe10s, OnThe15s, OnThe20s, OnThe30s, 
                                                  AfterEeveryTransaction, AfterEvery5Transactions, AfterEvery10Transactions, AfterEvery100Transactions,
                                                  AfterEvery1000Transactions, AfterEvery10000Transactions, AfterEvery100000Transactions,
                                                  AfterEvery1000000Transactions};

        public static bool useCurrentDateStampForTransaction {
            get { return mUseCurrentDateStampForTransaction; }
            set { mUseCurrentDateStampForTransaction = value; }
        }     

        public static DateTime startDate {
            get { return mStartDateTime; }
            set { mStartDateTime = value; }
        }
        public static DateTime throughDate {
            get { return mThroughDateTime; }
            set { mThroughDateTime = value; }
        }
        public static int couponAmountToAdd
        {
            get { return mCouponAmountToAdd; }
            set { mCouponAmountToAdd = value; }
        }

        //  This data structure is zero-based, same as the Item list indexing in cbStoreCheckInterval, etc. Make sure they synch up.
        public static String[] availableCheckIntervals = {"Never", 
                                                          "On the hour", "On the 1's", "On the 5's", "On the 10's", "On the 15's", "On the 20's", "On the 30's", 
                                                          "After every transaction", "After every 5 transactions", "After every 10 transactions", "After every 100 transactions", "After every 1000 transactions", "After every 10000 transactions", "After every 100000 transactions", "After every 1000000 transactions"};
        private static enum_availableCheckIntervals mStoreCheckInterval, mEmplCheckInterval, mProductCheckInterval, mCouponCheckInterval;

        public static enum_availableCheckIntervals storeCheckInterval {
            get { return mStoreCheckInterval; }
            set { mStoreCheckInterval = value; }
        }
        public static enum_availableCheckIntervals emplCheckInterval {
            get { return mEmplCheckInterval; }
            set { mEmplCheckInterval = value; }
        }
        public static enum_availableCheckIntervals productCheckInterval {
            get { return mProductCheckInterval; }
            set { mProductCheckInterval = value; }
        }
        public static enum_availableCheckIntervals couponCheckInterval
        {
            get { return mCouponCheckInterval; }
            set { mCouponCheckInterval = value; }
        }

        /// <summary>
        /// The maximum price change for a product when a new price is computed
        /// </summary>
        public static double maxPriceChangePct {
            get { return mMaxPriceChangePct; }
            set { mMaxPriceChangePct = value; }
        }

        public static int randomNumberSeed {
            get {return mRandomNumberSeed;}
            set {mRandomNumberSeed = value;}
        }
        public static bool useCoupons {
            get { return mUseCoupons; }
            set { mUseCoupons = value; }
        }
        /// <summary>
        /// All logic that needs a random number should use this!
        /// </summary>
        public static Random random {
            get {return mRandom; }
            set {mRandom = value;}
        }

        public static void initRandomNumberGenerator(int seed) {
            if (seed == 0) { Config.random = new Random(); } else { Config.random = new Random(seed); }
        }

        // Multiple Active Results Sets:
        // MARS: http://stackoverflow.com/questions/6062192/there-is-already-an-open-datareader-associated-with-this-command-which-must-be-c
        //public static string mConnectionString;

        public static int percentageOfPurchaseTransactions = 90;

        public enum modeEnum {idle, running};
        public static modeEnum mode;

        public static string connectionString {
            get {
                return "user id=" + login + ";" +
                       "password=" + password + " ;" + 
                       "server=" + server + ";" +
                       "Trusted_Connection=no;" +
                       "database=" + database + ";" +
                       "MultipleActiveResultSets=true; " +
                       "connection timeout=30";
            }
        }
        public static int getTransactionDelay() {return transactionDelay;}
        public static int setTransactionDelay(int transactionDelay) { Config.transactionDelay = transactionDelay; return transactionDelay; }
        public static string server {
            get { return mServer; }
            set { mServer = value; }
        }
        public static string login {
            get { return mLogin; }
            set { mLogin = value; }
        }
        public static string password {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public static string database {
            get { return mDatabase; }
            set { mDatabase = value; }
        }

        static Config()
        {
            emplList = new List<EmplName>();
            mServer = "IL-SERVER-001.uccc.uc.edu\\MSSQLSERVER2012";
            mLogin = "GroceryStoreSimulatorLogin";
            mPassword = "P@ssword";
            mDatabase = "GroceryStoreSimulator";
            mUseCoupons = false;
            mRandomNumberSeed = 42;
            cityList = new List<City>();
            mElapsedMinutesToRun = 1;       // Default
        }
        /// <summary>
        /// Read the .csv file with people names that we will use to make up random employee names
        /// </summary>
        /// <returns></returns>
        public static int loadEmployeNamesFromTextFile() {
            int count = 0;
            try {   // Open the text file using a stream reader.
                string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string filePath = Path.Combine(appDataFolder, "randomNames.csv");
                using (StreamReader sr = new StreamReader("..\\..\\data\\randomNames.csv")) {
                    // Read the stream to a string, and write the string to the console.
                    String line;
                    String[] name = new String[2];
                    while ((line = sr.ReadLine()) != null) {
                        name = line.Split(',');
                        emplList.Add(new EmplName(name[0], name[1]));
                        count++;
                        //Console.WriteLine(line);
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("The employee name file could not be read:");
                Console.WriteLine(e.Message);
            } finally {
            }
            return count;
        }
        /// <summary>
        /// Read the .csv file with people names that we will use to make up random employee names
        /// </summary>
        /// <returns></returns>
        public static int loadCitiesFromTextFile()
        {
            int count = 0;
            try {
                // Open the text file using a stream reader.
                string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string filePath = Path.Combine(appDataFolder, "randomCities.csv");
                using (StreamReader sr = new StreamReader("..\\..\\data\\randomCities.csv"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line;
                    String[] city = new String[12];
                    while ((line = sr.ReadLine()) != null)
                    {
                        city = line.Split(',');
                        cityList.Add(new City(city[2], city[3]));
                        count++;
                        //Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e) {
                Utils.Log("Config.loadCitiesFromTextFile(): " + e.Message);
                //Console.WriteLine(e.Message);
            }
            finally {
            }
            return count;
        }
    }
}

