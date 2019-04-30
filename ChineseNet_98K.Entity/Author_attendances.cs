using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace ChineseNet_98K.Entity
{
    /// <summary>
    /// ���߿��ڱ�
    /// </summary>
    public class Author_attendances
	{
		public Author_attendances()
		{}
		/// <summary>
		/// ����ID
		/// </summary>
		[Key]
		public int Author_attendanceId
		{
			get;set;
		}
		/// <summary>
		/// ����ID
		/// </summary>
		public int AuthorId
		{
			get;set;
		}
		/// <summary>
		/// ״̬ 1-10��״̬1000-10000��
		/// </summary>
		public int State
		{
			get;set;
		}

        /// <summary>
        /// С˵ID
        /// </summary>
        public int NovelId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateDate
		{
			get;set;
		}
	}
}

