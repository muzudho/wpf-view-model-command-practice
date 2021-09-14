namespace WpfViewModelCommandPractice.ViewModels
{
    using Livet.Commands;
    using System;
    using System.Diagnostics;

    public class MainWindowModel
    {
        private ViewModelCommand _calledHello;

        /// <summary>
        /// ハローと表示するコマンド
        /// </summary>
        public ViewModelCommand CalledHello
        {
            get
            {
                if (_calledHello == null)
                {
                    _calledHello = new ViewModelCommand(Hello);
                }
                return _calledHello;
            }
        }

        /// <summary>
        /// ハローと表示します
        /// </summary>
        public void Hello()
        {
            // Console.WriteLine("Hello, world!!"); // デバッグ中は働かなかった
            Trace.WriteLine("Hello, world!!"); // デバッグ中に働いた
        }
    }
}
