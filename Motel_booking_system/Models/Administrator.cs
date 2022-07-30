using System.Data;

namespace Motel_booking_system.Models
{
    public class Administrator
    {
        // Enum for defining admin account permissions
        public enum Permissions
        {
            CanReadnWrite = 1,
            CanRead = 2,
        }


        public string? Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Permission { get; set; }


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
                return string.Empty;
            }
            int oldNum = Convert.ToInt32(lastRow.Substring(2));
            oldNum = oldNum + 1;
            string newId = "A_" + oldNum.ToString("0000");
            return newId;
        }

    }

}
