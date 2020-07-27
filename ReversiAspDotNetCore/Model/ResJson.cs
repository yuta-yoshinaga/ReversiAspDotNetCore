////////////////////////////////////////////////////////////////////////////////
///	@file			ResJson.cs
///	@brief			レスポンスJSONクラス実装ファイル
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
	///	@class		ResJson
	///	@brief		レスポンスJSONクラス実装ファイル
	///
	////////////////////////////////////////////////////////////////////////////////
	public class ResJson
	{
		#region メンバ変数
        private string _auth;										//!< リターン値
        private CallbacksJson _callbacks;							//!< コールバックス
		#endregion

		#region プロパティ
		public string auth
		{
			get { return _auth; }
			set { _auth = value; }
		}
		public CallbacksJson callbacks
		{
			get { return _callbacks; }
			set { _callbacks = value; }
		}
		#endregion

		////////////////////////////////////////////////////////////////////////////////
		///	@brief			コンストラクタ
		///	@fn				ResJson()
		///	@return			ありません
		///	@author			Yuta Yoshinaga
		///	@date			2020.07.27
		///
		////////////////////////////////////////////////////////////////////////////////
		public ResJson()
		{
            this.callbacks = new CallbacksJson();
		}

		////////////////////////////////////////////////////////////////////////////////
		///	@brief			コピー
		///	@fn				ResJson Clone()
		///	@return			オブジェクトコピー
		///	@author			Yuta Yoshinaga
		///	@date			2020.07.27
		///
		////////////////////////////////////////////////////////////////////////////////
		public ResJson Clone()
		{
			return (ResJson)MemberwiseClone();
		}
	}
}
