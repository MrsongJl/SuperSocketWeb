using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocketWeb
{
    public class TestSession : AppSession<TestSession>
    {
        public int CustomID { get; set; }
        public string CustomName { get; set; }
        /// <summary>
        /// 用户连接会话
        /// </summary>
        protected override void OnSessionStarted()
        {
            Console.WriteLine("新的用户请求");
            base.OnSessionStarted();
        }

        /// <summary>
        /// 未知的用户请求命令
        /// </summary>
        /// <param name="requestInfo"></param>
        protected override void HandleUnknownRequest(StringRequestInfo requestInfo)
        {
            base.HandleUnknownRequest(requestInfo);
        }
        /// <summary>
        /// 会话关闭
        /// </summary>
        /// <param name="reason"></param>
        protected override void OnSessionClosed(CloseReason reason)
        {
            base.OnSessionClosed(reason);
        }
    }
}