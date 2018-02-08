# praxis
Design exercises

LocalStore evidence:
	(1) Ever increasing RAM (# OS handles)
	(2) Reset process (pools, etc.)
SqlStore evidence:
	(3) System.ServiceModel.FaultException`1[[System.ServiceModel.ExceptionDetail, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]: Timeout expired.  The timeout period elapsed prior to obtaining a connection from the pool.  This may have occurred because all pooled connections were in use and max pool size was reached.
	(4) For increased limit (default, each increment), when reached: reset process (pools, etc.)
