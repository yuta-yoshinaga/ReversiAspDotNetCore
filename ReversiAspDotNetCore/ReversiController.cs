using System;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReversiAspDotNetCore
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, Newtonsoft.Json.JsonConvert.SerializeObject(value));
        }
        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }

    public class ReversiController : ControllerBase
    {
        const string SessionKey = "_ReversiPlay";
        public ReversiPlay getReversiPlay()
        {
            ReversiPlay rvPlay = new ReversiPlay();
            if (HttpContext.Session.Get<ReversiPlay>(SessionKey) == default)
            {
                HttpContext.Session.Set<ReversiPlay>(SessionKey, rvPlay);
            }
            else
            {
                rvPlay = HttpContext.Session.Get<ReversiPlay>(SessionKey);
            }
            rvPlay.mCallbacks = new CallbacksJson();
            rvPlay.viewMsgDlg = this.ViewMsgDlg;
            rvPlay.drawSingle = this.DrawSingle;
            rvPlay.curColMsg = this.CurColMsg;
            rvPlay.curStsMsg = this.CurStsMsg;
            rvPlay.wait = this.Wait;
            return rvPlay;
        }

        public string getResJson(ReversiPlay rvPlay)
        {
            ResJson resJson = new ResJson();
            resJson.auth = "[SUCCESS]";
            resJson.callbacks = rvPlay.mCallbacks;
            HttpContext.Session.Set<ReversiPlay>(SessionKey, rvPlay);
            return Newtonsoft.Json.JsonConvert.SerializeObject(resJson);
        }

        public IActionResult setSetting([FromQuery(Name = "func")] string func, [FromQuery(Name = "para")] ReversiSetting para)
        {
            ReversiPlay rvPlay = this.getReversiPlay();
            rvPlay.mSetting = para;
            rvPlay.reset();
            return Content(this.getResJson(rvPlay), "application/json");
        }

        public IActionResult reset([FromQuery(Name = "func")] string func)
        {
            ReversiPlay rvPlay = this.getReversiPlay();
            rvPlay.reset();
            return Content(this.getResJson(rvPlay), "application/json");
        }

        public IActionResult reversiPlay([FromQuery(Name = "func")] string func, [FromQuery(Name = "y")] int y, [FromQuery(Name = "x")] int x)
        {
            ReversiPlay rvPlay = this.getReversiPlay();
            rvPlay.reversiPlay(y,x);
            return Content(this.getResJson(rvPlay), "application/json");
        }

        ////////////////////////////////////////////////////////////////////////////////
        ///	@brief			メッセージダイアログ
        ///	@fn				FuncsJson ViewMsgDlg(String title , String msg)
        ///	@param[in]		String title	タイトル
        ///	@param[in]		String msg		メッセージ
        ///	@return			FuncsJson
        ///	@author			Yuta Yoshinaga
        ///	@date			2020.07.27
        ///
        ////////////////////////////////////////////////////////////////////////////////
        public FuncsJson ViewMsgDlg(string title , string msg)
        {
            FuncsJson funcs = new FuncsJson();
            funcs.func = "ViewMsgDlg";
            funcs.param1 = title;
            funcs.param2 = msg;
            return funcs;
        }

        ////////////////////////////////////////////////////////////////////////////////
        ///	@brief			1マス描画
        ///	@fn				CallbacksJson DrawSingle(int y, int x, int sts, int bk, string text)
        ///	@param[in]		int y		Y座標
        ///	@param[in]		int x		X座標
        ///	@param[in]		int sts		ステータス
        ///	@param[in]		int bk		背景
        ///	@param[in]		string text	テキスト
        ///	@return			FuncsJson
        ///	@author			Yuta Yoshinaga
        ///	@date			2020.07.27
        ///
        ////////////////////////////////////////////////////////////////////////////////
        public FuncsJson DrawSingle(int y, int x, int sts, int bk, string text)
        {
            FuncsJson funcs = new FuncsJson();
            funcs.func = "DrawSingle";
            funcs.param1 = Convert.ToString(y);
            funcs.param2 = Convert.ToString(x);
            funcs.param3 = Convert.ToString(sts);
            funcs.param4 = Convert.ToString(bk);
            funcs.param5 = text;
            return funcs;
        }

        ////////////////////////////////////////////////////////////////////////////////
        ///	@brief			現在の色メッセージ
        ///	@fn				FuncsJson CurColMsg(string text)
        ///	@param[in]		string text	テキスト
        ///	@return			FuncsJson
        ///	@author			Yuta Yoshinaga
        ///	@date			2020.07.27
        ///
        ////////////////////////////////////////////////////////////////////////////////
        public FuncsJson CurColMsg(string text)
        {
            FuncsJson funcs = new FuncsJson();
            funcs.func = "CurColMsg";
            funcs.param1 = text;
            return funcs;
        }

        ////////////////////////////////////////////////////////////////////////////////
        ///	@brief			現在のステータスメッセージ
        ///	@fn				FuncsJson CurStsMsg(string text)
        ///	@param[in]		string text	テキスト
        ///	@return			FuncsJson
        ///	@author			Yuta Yoshinaga
        ///	@date			2020.07.27
        ///
        ////////////////////////////////////////////////////////////////////////////////
        public FuncsJson CurStsMsg(string text)
        {
            FuncsJson funcs = new FuncsJson();
            funcs.func = "CurStsMsg";
            funcs.param1 = text;
            return funcs;
        }

        ////////////////////////////////////////////////////////////////////////////////
        ///	@brief			ウェイト
        ///	@fn				FuncsJson Wait(int time)
        ///	@param[in]		int time	ウェイト時間(msec)
        ///	@return			FuncsJson
        ///	@author			Yuta Yoshinaga
        ///	@date			2020.07.27
        ///
        ////////////////////////////////////////////////////////////////////////////////
        public FuncsJson Wait(int time)
        {
            FuncsJson funcs = new FuncsJson();
            funcs.func = "Wait";
            funcs.param1 = Convert.ToString(time);
            return funcs;
        }

    }
}
