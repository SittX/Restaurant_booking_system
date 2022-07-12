﻿using System.Data;

namespace Restaurant_booking_system.Models
{
    public class Administrator
    {
        public string Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public static string GenerateId(DataTable dt)
        {
            int totalRows = dt.Rows.Count;
            if (totalRows < 1)
            {
                return "A_0001";
            }

            string? lastRow = dt.Rows[totalRows - 1][0].ToString();

            if (lastRow is null)
            {
                return String.Empty;
            }
            int oldNum = Convert.ToInt32(lastRow.Substring(2));
            oldNum = oldNum + 1;
            string newId = "A_" + oldNum.ToString("0000");
            return newId;
        }
    }

}
