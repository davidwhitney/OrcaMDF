namespace OrcaMDF.Core.MetaData.SystemEntities
{
	/// <summary>
	/// Matches sys.syscolpars
	/// </summary>
	public class SysRowsetColumn : DataRow
	{
		public SysRowsetColumn()
		{
			Columns.Add(new DataColumn("id", "int"));
			Columns.Add(new DataColumn("number", "smallint"));
			Columns.Add(new DataColumn("colid", "int"));
			Columns.Add(new DataColumn("name", "sysname", true));
			Columns.Add(new DataColumn("xtype", "tinyint"));
			Columns.Add(new DataColumn("utype", "int"));
			Columns.Add(new DataColumn("length", "smallint"));
			Columns.Add(new DataColumn("prec", "tinyint"));
			Columns.Add(new DataColumn("scale", "tinyint"));
			Columns.Add(new DataColumn("collationid", "int"));
			Columns.Add(new DataColumn("status", "int"));
			Columns.Add(new DataColumn("maxinrow", "smallint"));
			Columns.Add(new DataColumn("xmlns", "int"));
			Columns.Add(new DataColumn("dflt", "int"));
			Columns.Add(new DataColumn("chk", "int"));
			Columns.Add(new DataColumn("idtval", "varbinary", true));
		}

		public int ObjectID { get { return Field<int>("id"); } }
		public short Number { get { return Field<short>("number"); } }
		public int ColumnID { get { return Field<int>("colid"); } }
		public string Name { get { return Field<string>("name"); } }
		public byte XType { get { return Field<byte>("xtype"); } }
		public int UType { get { return Field<int>("utype"); } }
		public short Length { get { return Field<short>("length"); } }
		public byte Prec { get { return Field<byte>("prec"); } }
		public byte Scale { get { return Field<byte>("scale"); } }
		public int CollationID { get { return Field<int>("collationid"); } }
		public int Status { get { return Field<int>("status"); } }
		public short MaxInRow { get { return Field<short>("maxinrow"); } }
		public int XmlNS { get { return Field<int>("xmlns"); } }
		public int DFLT { get { return Field<int>("dflt"); } }
		public int CHK { get { return Field<int>("chk"); } }
		public byte[] IDTval { get { return Field<byte[]>("idtval"); } }
	}
}