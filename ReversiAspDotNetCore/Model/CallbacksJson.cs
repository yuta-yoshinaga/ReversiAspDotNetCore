////////////////////////////////////////////////////////////////////////////////
///	@file			CallbacksJson.cs
///	@brief			コールバックJSONクラス実装ファイル
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
	///	@class		CallbacksJson
	///	@brief		コールバックJSONクラス実装ファイル
	///
	////////////////////////////////////////////////////////////////////////////////
	public class CallbacksJson
	{
		#region メンバ変数
		private List<FuncsJson> _funcs;             //!< ファンクションズ
		#endregion

		#region プロパティ
		public List<FuncsJson> funcs
		{
			get { return _funcs; }
			set { _funcs = value; }
		}
		#endregion

		////////////////////////////////////////////////////////////////////////////////
		///	@brief			コンストラクタ
		///	@fn				CallbacksJson()
		///	@return			ありません
		///	@author			Yuta Yoshinaga
		///	@date			2020.07.27
		///
		////////////////////////////////////////////////////////////////////////////////
		public CallbacksJson()
		{
            this.funcs = new List<FuncsJson>();
		}

		////////////////////////////////////////////////////////////////////////////////
		///	@brief			コピー
		///	@fn				CallbacksJson Clone()
		///	@return			オブジェクトコピー
		///	@author			Yuta Yoshinaga
		///	@date			2020.07.27
		///
		////////////////////////////////////////////////////////////////////////////////
		public CallbacksJson Clone()
		{
			return (CallbacksJson)MemberwiseClone();
		}
	}
}
