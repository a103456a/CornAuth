FROM microsoft/aspnetcore:1.1
ARG source
WORKDIR /app
EXPOSE 80
RUN apt-get update
RUN apt-get install -y unzip
RUN curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l /clrdbg/vsdbg
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["dotnet", "CornAuth.dll"]
