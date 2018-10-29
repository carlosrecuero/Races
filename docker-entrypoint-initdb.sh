#!/bin/bash

# wait for database to start...
for i in {30..0}; do
  if sqlcmd -U SA -P 'Pass@word' -Q 'SELECT 1;' &> /dev/null; then
    echo "$0: SQL Server started"
    break
  fi
  echo "$0: SQL Server startup in progress..."
  sleep 1
done

echo "$0: SQL Server Database ready"