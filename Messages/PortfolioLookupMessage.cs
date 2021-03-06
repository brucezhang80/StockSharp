﻿namespace StockSharp.Messages
{
	using System;
	using System.Runtime.Serialization;

	using Ecng.Common;

	/// <summary>
	/// Сообщение поиска инструментов по заданному критерию.
	/// </summary>
	[DataContract]
	[Serializable]
	public class PortfolioLookupMessage : PortfolioMessage
	{
		/// <summary>
		/// Создать <see cref="PortfolioLookupMessage"/>.
		/// </summary>
		public PortfolioLookupMessage()
			: base(MessageTypes.PortfolioLookup)
		{
		}

		/// <summary>
		/// Создать копию объекта <see cref="PortfolioLookupMessage"/>.
		/// </summary>
		/// <returns>Копия.</returns>
		public override Message Clone()
		{
			return CopyTo(new PortfolioLookupMessage());
		}

		/// <summary>
		/// Получить строковое представление.
		/// </summary>
		/// <returns>Строковое представление.</returns>
		public override string ToString()
		{
			return base.ToString() + ",TransId={0},Curr={1},Board={2},IsSubscribe={3}".Put(TransactionId, Currency, BoardCode, IsSubscribe);
		}
	}
}