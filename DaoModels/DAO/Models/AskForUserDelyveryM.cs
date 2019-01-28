﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DaoModels.DAO.Models
{
    public class AskForUserDelyveryM
    {
        public int ID { get; set; }
        public string Have_you_inspected_the_vehicle_For_any_additional_imperfections_other_than_listed_at_the_pick_up { get; set; }
        public List<Photo> Have_you_inspected_the_vehicle_For_any_additional_imperfections_other_than_listed_at_the_pick_up_photo { get; set; }
        public string What_form_of_payment_are_you_using_to_pay_for_transportation { get; set; }
        public string App_will_ask_for_name_of_the_client_signature { get; set; }
        public Photo App_will_ask_for_signature_of_the_client_signature { get; set; }
    }
}