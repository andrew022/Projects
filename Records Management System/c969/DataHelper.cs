using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c969
{
    public static class AppointmentList
    {
        public static List<Appointments> Appointment { get; set; } = new List<Appointments>();
    }
    public class DataHelper
    {
        public static string Server { get; set; }
        public static string Port { get; set; }
        public static string DatabaseName { get; set; }
        public static string Uid { get; set; }
        public static string Pwd { get; set; }

    }

    public class Appointments
    {
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string UserName {  get; set; }
        public string CustomerName {  get; set; }
    }
}
