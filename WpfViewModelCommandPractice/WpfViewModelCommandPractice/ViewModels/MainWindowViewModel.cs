namespace WpfViewModelCommandPractice.ViewModels
{
    using Livet.Commands;
    using System.Diagnostics;
    using System.Windows;

    public class MainWindowViewModel
    {
        private ViewModelCommand _helloCommand;

        /// <summary>
        /// ハローと表示するコマンド
        /// </summary>
        public ViewModelCommand CalledHello
        {
            get
            {
                if (_helloCommand == null)
                {
                    _helloCommand = new ViewModelCommand(Hello);
                }
                return _helloCommand;
            }
        }

        /// <summary>
        /// ハローと表示します
        /// </summary>
        public void Hello()
        {
            // コンソール出力
            // Console.WriteLine("Hello, world!!"); // デバッグ中は働かなかった
            Trace.WriteLine("Hello, world!!"); // デバッグ中に働いた

            var _result = MessageBox.Show(
                "ハロー！\nわたしはWindowsデフォルトのメッセージボックスです",
                "コマンド",
                MessageBoxButton.OK,
                MessageBoxImage.Information,
                MessageBoxResult.OK);
        }
    }
}
