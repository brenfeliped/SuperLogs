﻿using SuperLogs.Model;
using SuperLogs.Model.Context;
using SuperLogs.Transport;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperLogs.Service
{
    public class LogService : ILogService
    {
        private AppDbContext _context;

        public LogService(AppDbContext context)
        {
            _context = context;
        }

        public IList<Log> BuscaPorData(DateTime data)
        {
            throw new System.NotImplementedException();
        }

        public IList<Log> BuscaPorEventos(int eventos)
        {
            throw new System.NotImplementedException();
        }

        public IList<Log> BuscaPorHostName(string hostName)
        {
            throw new System.NotImplementedException();
        }

        public Log BuscaPorId(int id)
        {
            return _context.Log.FirstOrDefault(log => log.IdLog == id);
        }

        public IList<Log> BuscaPorIdAmbiente(int idAmbiente)
        {
            return _context.Log.Where(log => log.IdAmbiente == idAmbiente).ToList();
        }

        public IList<Log> BuscaPorIdStatus(int idStatus)
        {
            return _context.Log.Where(log => log.IdStatus == idStatus).ToList();
        }

        public IList<Log> BuscaPorIdTipoLog(int idTipoLog)
        {
            return _context.Log.Where(log => log.IdTipoLog == idTipoLog).ToList();
        }

        public IList<Log> BuscaPorIdUsuario(int idUsuario)
        {
            return _context.Log.Where(log => log.IdUsuario == idUsuario).ToList();
        }

        public IList<Log> BuscaPorTitulo(string titulo)
        {
            return _context.Log.Where(log => log.Titulo.Contains(titulo)).ToList();
        }

        public void Criar(CriarLogDto log)
        {
            var logModel = ParaLog(log);
            _context.Log.Add(logModel);
            _context.SaveChanges();

            log.IdLog = logModel.IdLog;
        }

        private Log ParaLog(CriarLogDto log)
        {
            return new Log
            {
                IdLog = log.IdLog,
                Data = log.Data,
                Descricao = log.Descricao,
                Eventos = log.Eventos,
                Host = log.Host,
                IdAmbiente = log.IdAmbiente,
                IdStatus = log.IdStatus,
                IdTipoLog = log.IdTipoLog,
                IdUsuario = log.IdUsuario,
                Titulo = log.Titulo
            };
        }
    }
}
