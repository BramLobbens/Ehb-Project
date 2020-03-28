using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAppXam.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Chat,
        Login
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
