using DataAccess.DataContext;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class PollRepository
    {
        private PollDbContext _pollDbContext;
        public PollRepository(PollDbContext pollDbContext) 
        {
            _pollDbContext = pollDbContext;
        }

        public void AddPoll(Poll newPoll)
        {
            newPoll.DateCreated = DateTime.Now;
            newPoll.Option1VotesCount = 0;
            newPoll.Option2VotesCount = 0;
            newPoll.Option3VotesCount = 0;

            _pollDbContext.Polls.Add(newPoll);
            _pollDbContext.SaveChanges();
        }

        public IQueryable<Poll> GetPolls()
        {
            return _pollDbContext.Polls;
        }

        public Poll GetPollById(int pollId)
        {
            return _pollDbContext.Polls.SingleOrDefault(p => p.PollID == pollId);
        }

    }
}
