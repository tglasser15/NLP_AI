﻿

#pragma checksum "C:\Users\MooreAlec\documents\visual studio 2013\Projects\NLP_AI\NLP_AI\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "37E35430B5422AC76661FDF1F276C259"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NLP_AI
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton SpeakButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton StopButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton CancelButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Bing.Speech.Xaml.SpeechRecognizerUx SpeechControl; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Shapes.Rectangle VolumeMeter; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.StackPanel InitPanel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.StackPanel ListenPanel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.StackPanel ThinkPanel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.StackPanel CompletePanel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.StackPanel StartPanel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock ResultText; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///MainPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            SpeakButton = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("SpeakButton");
            StopButton = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("StopButton");
            CancelButton = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("CancelButton");
            SpeechControl = (global::Bing.Speech.Xaml.SpeechRecognizerUx)this.FindName("SpeechControl");
            VolumeMeter = (global::Windows.UI.Xaml.Shapes.Rectangle)this.FindName("VolumeMeter");
            InitPanel = (global::Windows.UI.Xaml.Controls.StackPanel)this.FindName("InitPanel");
            ListenPanel = (global::Windows.UI.Xaml.Controls.StackPanel)this.FindName("ListenPanel");
            ThinkPanel = (global::Windows.UI.Xaml.Controls.StackPanel)this.FindName("ThinkPanel");
            CompletePanel = (global::Windows.UI.Xaml.Controls.StackPanel)this.FindName("CompletePanel");
            StartPanel = (global::Windows.UI.Xaml.Controls.StackPanel)this.FindName("StartPanel");
            ResultText = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("ResultText");
        }
    }
}



