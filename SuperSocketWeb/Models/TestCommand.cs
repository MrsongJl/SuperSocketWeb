using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocketWeb
{
    public class TestCommand : CommandBase<TestSession, StringRequestInfo>
    {
        /// <summary>
        /// 命令处理类
        /// </summary>
        /// <param name="session"></param>
        /// <param name="requestInfo"></param>
        public override void ExecuteCommand(TestSession session, StringRequestInfo requestInfo)
        {
            session.CustomID = new Random().Next(10000, 99999);
            session.CustomName = "hello word";
            //var key = requestInfo.Key;
            //var param = requestInfo.Parameters;
            //var body = requestInfo.Body;
            //Console.WriteLine(key);
            //Console.WriteLine(param);
            //Console.WriteLine(body);

            //session.Send(session.CustomID.ToString());
            session.Send(requestInfo.Body);

        }
    }
}