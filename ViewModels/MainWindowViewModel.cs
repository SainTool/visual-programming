using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using ReactiveUI;
using Regexx.Models;

namespace Regexx.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        string text;
        public string Text
        {
            get => text;
            set => this.RaiseAndSetIfChanged(ref text, value);
        }
        string pattern;

        public string Pattern
        {
            get => pattern;
            set => this.RaiseAndSetIfChanged(ref pattern, value);
        }
        string result;
        public string RegularResult
        {
            get => result;
            set => this.RaiseAndSetIfChanged(ref result, value);
        }
        public string? FindRegular() => MyRegex.FindRegexInText(text, pattern);

    }
}