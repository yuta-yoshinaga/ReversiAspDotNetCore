////////////////////////////////////////////////////////////////////////////////
///	@file			FuncsJson.cs
///	@brief			ファンクションJSONクラス実装ファイル
///	@author			Yuta Yoshinaga
///	@date			2020.07.27
///	$Version:		$
///	$Revision:		$
///
/// Copyright (c) 2020 Yuta Yoshinaga. All Rights reserved.
///
/// - 本ソフトウェアの一部又は全てを無断で複写複製（コピー）することは、
///   著作権侵害にあたりますので、これを禁止します。
/// - 本製品の使用に起因する侵害または特許権その他権利の侵害に関しては
///   当社は一切その責任を負いません。
///
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReversiAspDotNetCore
{
	////////////////////////////////////////////////////////////////////////////////
	///	@class		FuncsJson
	///	@brief		ファンクションJSONクラス実装ファイル
	///
	////////////////////////////////////////////////////////////////////////////////
	public class FuncsJson
	{
		#region メンバ変数
		private string _func;                       //!< ファンクション
		private string _param1;                     //!< パラメーター1
		private string _param2;                     //!< パラメーター2
		private string _param3;                     //!< パラメーター3
		private string _param4;                     //!< パラメーター4
		private string _param5;                     //!< パラメーター5
		#endregion

		#region プロパティ
		public string func
		{
			get { return _func; }
			set { _func = value; }
		}
		public string param1
		{
			get { return _param1; }
			set { _param1 = value; }
		}
		public string param2
		{
			get { return _param2; }
			set { _param2 = value; }
		}
		public string param3
		{
			get { return _param3; }
			set { _param3 = value; }
		}
		public string param4
		{
			get { return _param4; }
			set { _param4 = value; }
		}
		public string param5
		{
			get { return _param5; }
			set { _param5 = value; }
		}
		#endregion

		////////////////////////////////////////////////////////////////////////////////
		///	@brief			コンストラクタ
		///	@fn				FuncsJson()
		///	@return			ありません
		///	@author			Yuta Yoshinaga
		///	@date			2020.07.27
		///
		////////////////////////////////////////////////////////////////////////////////
		public FuncsJson()
		{
		}

		////////////////////////////////////////////////////////////////////////////////
		///	@brief			コピー
		///	@fn				FuncsJson Clone()
		///	@return			オブジェクトコピー
		///	@author			Yuta Yoshinaga
		///	@date			2020.07.27
		///
		////////////////////////////////////////////////////////////////////////////////
		public FuncsJson Clone()
		{
			return (FuncsJson)MemberwiseClone();
		}
	}
}
