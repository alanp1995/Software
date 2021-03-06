﻿using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TrainTicketSys
{
    class Schedules
    {
        private static OracleConnection con;

        // Class Attributes
        private int scheduleID;
        private int routeID;
        private int dayOfWeek;
        private string departTime;
        private string arrivalTime;
        private char status;

        // No Argument Constrcutor
        public Schedules ()
        {
            this.scheduleID = 0; this.routeID = 0;
            this.dayOfWeek = 0; this.departTime = "00:00:00"; this.arrivalTime = "00:00:00";
        }

        // Argument Constructor
        public Schedules (int scheduleID, int routeID, int dayOfWeek, string departTime, string arrivalTime)
        {
            setScheduleID(scheduleID); setRouteID(routeID); setDayOfWeek(dayOfWeek);
            setDepartTime(departTime); setArrivalTime(arrivalTime);
        }

        // Setters and Getters
        // Schedule ID
        public void setScheduleID (int scheduleID)
        {
            this.scheduleID = scheduleID;
        }
        public int getScheduleID ()
        {
            return this.scheduleID;
        }
        // Route ID
        public void setRouteID (int routeID)
        {
            this.routeID = routeID;
        }
        public int getRouteID ()
        {
            return this.routeID;
        }
        // Day of Week
        public void setDayOfWeek (int dayOfWeek)
        {
            this.dayOfWeek = dayOfWeek;
        }
        public int getDayOfWeek ()
        {
            return this.dayOfWeek;
        }
        // Depart Time
        public void setDepartTime (string departTime)
        {
            this.departTime = departTime;
        }
        public string getDepartTime ()
        {
            return this.departTime;
        }
        // Arrival Time
        public void setArrivalTime (string arrivalTime)
        {
            this.arrivalTime = arrivalTime;
        }
        public string getArrivalTime ()
        {
            return this.arrivalTime;
        }

        // Method To Retrieve the Next Schedule ID
        public static int nextScheduleID()
        {
            int nextScheduleID;
            con = new OracleConnection(DBConnect.oradb);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            String strSQL = "SELECT MAX(scheduleID) FROM Schedules";

            OracleCommand cmd = new OracleCommand(strSQL, con);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.IsDBNull(0))
                nextScheduleID = 1;
            else
                nextScheduleID = Convert.ToInt32(dr.GetValue(0)) + 1;

            con.Close();
            return nextScheduleID;
        }

        // Method To Create Schedule
        public void createSchedule ()
        {
            // Connect to DB
            con = new OracleConnection(DBConnect.oradb);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Define SQL Query
            string strSQL =
                "INSERT INTO Schedules (scheduleID, routeID, dayOfWeek, depTime, arrTime) VALUES ("
                + this.scheduleID + ","
                + this.routeID + ","
                + this.dayOfWeek + ",'"
                + this.departTime + "','"
                + this.arrivalTime + "')";

            // Execute Command/Query
            OracleCommand cmd = new OracleCommand(strSQL, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Close Database Connection
            con.Close();
        }

        // Get Schedules According to Route ID
        public static DataSet getRouteSchedules(DataSet DS, int routeID)
        {
            con = new OracleConnection(DBConnect.oradb);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string SQL = @"SELECT Schedules.ScheduleID, Schedules.RouteID,
                            CASE Schedules.dayOfWeek
                            WHEN 1 THEN 'Monday'
                            WHEN 2 THEN 'Tuesday'
                            WHEN 3 THEN 'Wednesday'
                            WHEN 4 THEN 'Thursday'
                            WHEN 5 THEN 'Friday'
                            WHEN 6 THEN 'Saturday'
                            WHEN 7 THEN 'Sunday'
                           END AS dayOfWeek, Schedules.depTime, Schedules.arrTime, Schedules.Status
                           FROM Schedules WHERE routeID = " + routeID + " AND status = 'A'";

            OracleCommand cmd = new OracleCommand(SQL, con);
            OracleDataAdapter DA = new OracleDataAdapter(cmd);

            try
            {
                DA.Fill(DS, "Schedules");
            } 
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

            return DS;
        }

        // Get Schedule According To Route ID and Day of the Week
		public static DataSet getScheduleByDay(DataSet DS, int routeID, int dayOfWeek)
		{
			con = new OracleConnection(DBConnect.oradb);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string SQL = @"SELECT * FROM Schedules WHERE routeID = " + routeID + "AND dayOfWeek = " + dayOfWeek;

			OracleCommand cmd = new OracleCommand(SQL, con);
			OracleDataAdapter DA = new OracleDataAdapter(cmd);

			DA.Fill(DS, "Schedules");

			con.Close();

			return DS;
		}

        // Terminate Schedule According To Route ID
        public static void terminateScheduleByRoute (int routeID)
        {
            con = new OracleConnection(DBConnect.oradb);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string SQL = @"UPDATE Routes SET status = 'T' WHERE routeID = " + routeID;
            OracleCommand cmd = new OracleCommand(SQL, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        // Terminate Schedules According To A List of Routes
        public static void terminateSchedules(List<Routes> routes)
        {
            con = new OracleConnection(DBConnect.oradb);
            con.Open();

            var cmd = con.CreateCommand();

            foreach (var route in routes)
            {
                cmd.CommandText = @"UPDATE Schedules SET status = 'T' WHERE RouteID = " + route.getRouteID();

                cmd.ExecuteNonQuery();
            }

            con.Close();
        }
    }
}
