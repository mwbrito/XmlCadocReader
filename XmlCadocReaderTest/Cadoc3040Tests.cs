using XmlCadocReader;
using Xunit;

public class Cadoc3040Tests
{
    public string CadocUrl = System.AppContext.BaseDirectory + "../../../data/sample.xml";

    [Fact]
    public void ReatAttributeFromElementDoc3040()
    {
        Cadoc3040File doc = ReadCadocs.ReadCadoc3040File(CadocUrl);

        Assert.Equal("2014-02", doc.DtBase);
    }

    [Fact]
    public void ReatAttributeFromElementCli()
    {
        Cadoc3040File doc = ReadCadocs.ReadCadoc3040File(CadocUrl);

        Assert.Equal("003818", doc.cli.Cd);
    }

    [Fact]
    public void ReatAttributeFromElementOp()
    {
        Cadoc3040File doc = ReadCadocs.ReadCadoc3040File(CadocUrl);

        Assert.Equal("000000223", doc.cli.op.DetCli);
    }

    [Fact]
    public void ReatAttributeFromElementVenc()
    {
        Cadoc3040File doc = ReadCadocs.ReadCadoc3040File(CadocUrl);

        Assert.Equal("1000", doc.cli.op.venc.v110);
    }

    [Fact]
    public void ReatAttributeFromElementGar()
    {
        Cadoc3040File doc = ReadCadocs.ReadCadoc3040File(CadocUrl);

        Assert.Equal("0902", doc.cli.op.gar.Tp);
    }

    [Fact]
    public void ReatAttributeFromElementAgre()
    {
        Cadoc3040File doc = ReadCadocs.ReadCadoc3040File(CadocUrl);

        Assert.Equal("0101", doc.agre[0].Mod);
    }
}
