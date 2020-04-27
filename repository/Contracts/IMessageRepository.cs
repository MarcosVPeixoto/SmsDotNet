using SmsDotNet.repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SmsDotNet.Entities;
namespace SmsDotNet.Repository.Contracts
{
    interface IMessageRepository : IRepository <MessageModel>
    {
        public Task GetTalk(int IdOwner, int IdTarget);
        public Task DeleteByOwner(int IdOwner, int IdTarget);
        public Task DeleteByTarget(int IdOwner, int IdTarget);
        public Task DeleteTalk(int IdOwner, int IdTarget);
        public Task DeleteAllTalks(int IdOwner);
        public Task GetLastMessages(int IdOwner);
    }
}
