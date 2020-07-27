////////////////////////////////////////////////////////////////////////////////
///	@file			ReversiPoint.cs
///	@brief			リバーシポイントクラス実装ファイル
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
	///	@class		ReversiPoint
	///	@brief		リバーシポイント
	///
	////////////////////////////////////////////////////////////////////////////////
	public class ReversiPoint
	{
		#region メンバ変数
		private int _x;								//!< X
		private int _y;								//!< Y
		#endregion

		#region プロパティ
		public int x
		{
			get { return _x; }
			set { _x = value; }
		}
		public int y
		{
			get { return _y; }
			set { _y = value; }
		}
		#endregion

		////////////////////////////////////////////////////////////////////////////////
		///	@brief			コンストラクタ
		///	@fn				ReversiPoint()
		///	@return			ありません
		///	@author			Yuta Yoshinaga
		///	@date			2020.07.27
		///
		////////////////////////////////////////////////////////////////////////////////
		public ReversiPoint()
		{
		}

		////////////////////////////////////////////////////////////////////////////////
		///	@brief			コピー
		///	@fn				ReversiPoint Clone()
		///	@return			オブジェクトコピー
		///	@author			Yuta Yoshinaga
		///	@date			2020.07.27
		///
		////////////////////////////////////////////////////////////////////////////////
		public ReversiPoint Clone()
		{
			return (ReversiPoint)MemberwiseClone();
		}
	}
}
