using ScoreEngine.API.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreEngine.API.Data
{
    public class DbHelperService
    {
        internal IQueryable<ResultDto> GetScoreData()
        {
            var db = new ScoreEngineContext();
            return db.Results.Select(x => new ResultDto
            {
                Name = x.Name,
                UId = x.UId.ToString(),
                Score = x.Score
            }).OrderByDescending(x => x.Score);
        }

        internal bool AddScoreData(string name, int score)
        {
            var db = new ScoreEngineContext();
            db.Results.Add(new Models.Result
            {
                Name = name,
                Score = score,
                UId = Guid.NewGuid(),
                AddedDate = DateTime.Now
            });

            db.SaveChanges();

            return true;
        }
    }
}
