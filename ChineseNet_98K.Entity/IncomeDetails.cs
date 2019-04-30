using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace ChineseNet_98K.Entity
{
    /// <summary>
    ///�����ϸ��
    /// </summary>
    public class IncomeDetails
	{
		public IncomeDetails()
		{}
		/// <summary>
		/// ����ID
		/// </summary>
		[Key]
		public int IncomeDetailId
		{
			get;set;
		}
		/// <summary>
		/// ��������  1����2vip�½�3ȫ�ڽ�4���а���
		/// </summary>
		public int Types
		{
			get;set;
		}
		/// <summary>
		/// С˵ID
		/// </summary>
		public int NovelId
		{
			get;set;
		}
		/// <summary>
		/// ���
		/// </summary>
		public decimal ProfitNum
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
		/// ����ʱ��
		/// </summary>
		public DateTime CreateDate
		{
			get;set;
		}
	}
}

