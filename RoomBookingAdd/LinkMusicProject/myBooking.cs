using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkMusicProject
{
    class myBooking
    {
        private int GroupID, RoomID, SlotID;
        private string EquipmentRequest;
        private string Date;
 
        public myBooking()
        {

            this.GroupID = 0;
            this.RoomID = 0;
            this.SlotID = 0;
            this.EquipmentRequest = "";
            this.Date = "";
            
        }
        public myBooking(int GroupID, int RoomID, int SlotID, string EquipmentRequest,
            string Date)
        {
            this.GroupID = GroupID;
            this.RoomID = RoomID;
            this.SlotID = SlotID;
            this.EquipmentRequest = EquipmentRequest;
            this.Date = Date;

        }
        public int groupID
        {
            get { return GroupID; }
            set { GroupID = value; }
        }

        public int roomID
        {
            get { return RoomID; }
            set { RoomID = value; }
        }

        public int slotID
        {
            get { return SlotID ; }
            set { SlotID = value; }
        }

        public string equipmentRequest
        {
            get { return EquipmentRequest; }
            set { EquipmentRequest = value; }
        }

        public string date
        {
            get { return Date; }
            set { Date = value; }
        }
    }
}
