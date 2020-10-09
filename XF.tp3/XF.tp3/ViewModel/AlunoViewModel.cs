using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using XF.tp3.Model;

namespace XF.tp3.ViewModel
{
    class AlunoViewModel
    {
        public AlunoViewModel() { }

        #region Propriedades
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Aluno> Alunos
        {
            get
            {
                return App.AlunoModel.GetAlunos().ToList();
            }
        }
        #endregion
    }
}