﻿using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptors
{
	public class MethodInterception : MethodInterceptionBaseAttribute
	{
		protected virtual void OnBefore(IInvocation invocation) { }

		protected virtual void OnAfter(IInvocation invocation) { }

		protected virtual void OnException(IInvocation invocation, Exception e) { }

		protected virtual void OnSuccess(IInvocation invocation) { }

		public override void Intercept(IInvocation invocation)
		{
			bool isSuccess = true;
			OnBefore(invocation);
			try
			{
				invocation.Proceed();
			}
			catch(Exception e)
			{
				OnException(invocation, e);
				isSuccess = false;
			}
			finally
			{
				if (isSuccess)
				{
					OnSuccess(invocation);
				}
			}
		}

	}
}

