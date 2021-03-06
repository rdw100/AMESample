﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AME.UI.Win.Views
{
    // Represents a single member view.
    public interface IMemberView : IView
    {
        int MemberId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
        void ShowMessage(string Message);
        event EventHandler<EventArgs> Save;
    }
}
