using System;
using Stylet;

namespace StyletDemo.Pages
{
    public class ShellViewModel : Screen
    {
        public string Name { get; set; } = "waku";

        public void SayHello() => Name = "Hello" + Name;

        public bool CanSayHello => !string.IsNullOrEmpty(Name);
    }
}
