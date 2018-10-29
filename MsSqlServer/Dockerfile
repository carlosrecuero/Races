FROM microsoft/mssql-server-linux:2017-latest
WORKDIR /src
EXPOSE 1433
RUN ln -s /opt/mssql-tools/bin/sqlcmd /usr/local/bin/sqlcmd \
    && ln -s /opt/mssql-tools/bin/bcp /usr/local/bin/bcp
COPY src/MsSqlServer/docker-entrypoint.sh /usr/local/bin/
COPY src/MsSqlServer/docker-entrypoint-initdb.sh /usr/local/bin/
ENTRYPOINT ["docker-entrypoint.sh"]