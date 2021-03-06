﻿using System;
using PureCinema.DataAccess.Models;
using PureCinema.DataAccess.Repositories;

namespace PureCinema.Business.AuditLogging
{
	public class AuditLogger
	{
		private IAuditRepository _repository;
		private int _userId;

		public AuditLogger(int userId)
		{
			_repository = new EFAuditRepository();
			_userId = userId;
		}

		public void LogChanges(string action)
		{
			_repository.Add(new AuditLog
			{
				UserId = _userId,
				ChangeTime = DateTime.Now,
				Changes = action
			});
		}
	}
}
