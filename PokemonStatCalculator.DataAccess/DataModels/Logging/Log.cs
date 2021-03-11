using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonStatCalculator.DataAccess.DataModels.Logging
{
    public class Log
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public DateTime LoggedAt { get; set; }

        public string LogMessage { get; set; }

        [StringLength(10)]
        public string LogLevel { get; set; }

        public string LogException { get; set; }

        public string LogTrace { get; set; }

        public string Logger { get; set; }
    }
}