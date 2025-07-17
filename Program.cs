using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


BenchmarkRunner.Run<AllocationBenchmark>();

[MemoryDiagnoser]
public class AllocationBenchmark
{
    private const int Count = 10_000;
    #region PointRecord
    public record PointRecord(int x, int y);
    #endregion

    #region PointClass
    public class PointClass
    {
        public int X;
        public int Y;
        public PointClass(int x, int y) => (X, Y) = (x, y);
    }
    #endregion

    #region PointSealedRecord
    public sealed record PointSealedRecord(int x, int y);
    #endregion

    #region PointSealedClass
    public sealed class PointSealedClass
    {
        public int X;
        public int Y;
        public PointSealedClass(int x, int y) => (X, Y) = (x, y);
    }
    #endregion

    #region PointRecordStruct
    public record struct PointRecordStruct(int x, int y);
    #endregion

    #region PointStruct
    public struct PointStruct
    {
        public int X;
        public int Y;
        public PointStruct(int x, int y) => (X, Y) = (x, y);
    }
    #endregion

    #region PointReadonlyStruct
    public readonly struct PointReadonlyStruct
    {
        public readonly int X;
        public readonly int Y;
        public PointReadonlyStruct(int x, int y) => (X, Y) = (x, y);
    }
    #endregion

    #region ReadOnlyRecordStruct
    public readonly record struct PointReadonlyRecordStruct(int X, int Y);
    #endregion


    #region PointRecordXL
    public record PointRecordXL(Guid a, Guid b, string c, string d, decimal e, decimal f,
            int g, int h, int i, int j, int k, int l, int m, int n, int o,
            int p, int q, int r, int s, int t, int u, int v, int w, int x, int y, int z);
    #endregion

    #region PointClassXL
    public class PointClassXL
    {
        public Guid A;
        public Guid B;
        public string C;
        public string D;
        public decimal E;
        public decimal F;
        public int G;
        public int H;
        public int I;
        public int J;
        public int K;
        public int L;
        public int M;
        public int N;
        public int O;
        public int P;
        public int Q;
        public int R;
        public int S;
        public int T;
        public int U;
        public int V;
        public int W;
        public int X;
        public int Y;
        public int Z;

        public PointClassXL(Guid a, Guid b, string c, string d, decimal e, decimal f,
            int g, int h, int i, int j, int k, int l, int m, int n, int o,
            int p, int q, int r, int s, int t, int u, int v, int w, int x, int y, int z) =>
            (A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z)
            = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z);
    }
    #endregion

    #region PointSealedRecordXL
    public sealed record PointSealedRecordXL(Guid a, Guid b, string c, string d, decimal e, decimal f,
            int g, int h, int i, int j, int k, int l, int m, int n, int o,
            int p, int q, int r, int s, int t, int u, int v, int w, int x, int y, int z);
    #endregion

    #region PointSealedClassXL
    public sealed class PointSealedClassXL
    {
        public Guid A;
        public Guid B;
        public string C;
        public string D;
        public decimal E;
        public decimal F;
        public int G;
        public int H;
        public int I;
        public int J;
        public int K;
        public int L;
        public int M;
        public int N;
        public int O;
        public int P;
        public int Q;
        public int R;
        public int S;
        public int T;
        public int U;
        public int V;
        public int W;
        public int X;
        public int Y;
        public int Z;

        public PointSealedClassXL(Guid a, Guid b, string c, string d, decimal e, decimal f,
            int g, int h, int i, int j, int k, int l, int m, int n, int o,
            int p, int q, int r, int s, int t, int u, int v, int w, int x, int y, int z) =>
            (A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z)
            = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z);
    }
    #endregion

    #region PointRecordStructXL

    public record struct PointRecordStructXL(Guid a, Guid b, string c, string d, decimal e, decimal f,
            int g, int h, int i, int j, int k, int l, int m, int n, int o,
            int p, int q, int r, int s, int t, int u, int v, int w, int x, int y, int z);

    #endregion

    #region PointStructXL
    public struct PointStructXL
    {
        public Guid A;
        public Guid B;
        public string? C;
        public string? D;
        public decimal E;
        public decimal F;
        public int G;
        public int H;
        public int I;
        public int J;
        public int K;
        public int L;
        public int M;
        public int N;
        public int O;
        public int P;
        public int Q;
        public int R;
        public int S;
        public int T;
        public int U;
        public int V;
        public int W;
        public int X;
        public int Y;
        public int Z;

        public PointStructXL(Guid a, Guid b, string? c, string? d, decimal e, decimal f,
            int g, int h, int i, int j, int k, int l, int m, int n, int o,
            int p, int q, int r, int s, int t, int u, int v, int w, int x, int y, int z) =>
            (A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z)
            = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z);
    }

    #endregion

    #region PointReadonlyStructXL

    public readonly struct PointReadonlyStructXL
    {
        public readonly Guid A;
        public readonly Guid B;
        public readonly string? C;
        public readonly string? D;
        public readonly decimal E;
        public readonly decimal F;
        public readonly int G;
        public readonly int H;
        public readonly int I;
        public readonly int J;
        public readonly int K;
        public readonly int L;
        public readonly int M;
        public readonly int N;
        public readonly int O;
        public readonly int P;
        public readonly int Q;
        public readonly int R;
        public readonly int S;
        public readonly int T;
        public readonly int U;
        public readonly int V;
        public readonly int W;
        public readonly int X;
        public readonly int Y;
        public readonly int Z;

        public PointReadonlyStructXL(Guid a, Guid b, string? c, string? d, decimal e, decimal f,
            int g, int h, int i, int j, int k, int l, int m, int n, int o,
            int p, int q, int r, int s, int t, int u, int v, int w, int x, int y, int z) =>
            (A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z)
            = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z);
    }
    #endregion

    #region PointReadonlyRecordStructXL
    public readonly record struct PointReadonlyRecordStructXL(Guid A, Guid B, string C, string D, decimal E, decimal F,
        int G, int H, int I, int J, int K, int L, int M, int N, int O,
        int P, int Q, int R, int S, int T, int U, int V, int W, int X, int Y, int Z);


    #endregion


    #region Allocations

    #region AllocateClasses
    [Benchmark]
    public int AllocateClasses()
    {
        var list = new List<PointClass>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointClass(i, i));
        return list.Count;
    }
    #endregion

    #region AllocateSealedClasses


    [Benchmark]
    public int AllocateSealedClasses()
    {
        var list = new List<PointSealedClass>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointSealedClass(i, i));
        return list.Count;
    }

    #endregion

    #region AllocateRecords

    [Benchmark]
    public int AllocateRecords()
    {
        var list = new List<PointRecord>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointRecord(i, i));
        return list.Count;
    }
    #endregion

    #region AllocateSealedRecords

    [Benchmark]
    public int AllocateSealedRecords()
    {
        var list = new List<PointRecord>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointRecord(i, i));
        return list.Count;
    }
    #endregion

    #region AllocateStructs
    [Benchmark]
    public int AllocateStructs()
    {
        var list = new List<PointStruct>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointStruct(i, i));
        return list.Count;
    }
    #endregion

    #region AllocateReadonlyStructs

    [Benchmark]
    public int AllocateReadonlyStructs()
    {
        var list = new List<PointReadonlyStruct>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointReadonlyStruct(i, i));
        return list.Count;
    }
    #endregion

    #region AllocateRecordStructs

    [Benchmark]
    public int AllocateRecordStructs()
    {
        var list = new List<PointRecordStruct>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointRecordStruct(i, i));
        return list.Count;
    }
    #endregion

    #region AllocateReadonlyRecordStructs

    [Benchmark]
    public int AllocateReadonlyRecordStructs()
    {
        var list = new List<PointReadonlyRecordStruct>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointReadonlyRecordStruct(i, i));
        return list.Count;
    }
    #endregion


    #region AllocateClassXL

    [Benchmark]
    public int AllocateClassXL()
    {
        var list = new List<PointClassXL>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointClassXL(Guid.Empty, Guid.Empty, "A", "B", 1m, 2m,
                i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i));
        return list.Count;
    }
    #endregion

    #region AllocateRecordXL

    [Benchmark]
    public int AllocateRecordXL()
    {
        var list = new List<PointRecordXL>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointRecordXL(Guid.Empty, Guid.Empty, "A", "B", 1m, 2m,
                i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i));
        return list.Count;
    }

    #endregion

    #region AllocateSealedClassXL
    [Benchmark]
    public int AllocateSealedClassXL()
    {
        var list = new List<PointSealedClassXL>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointSealedClassXL(Guid.Empty, Guid.Empty, "A", "B", 1m, 2m,
                i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i));
        return list.Count;
    }
    #endregion

    #region AllocateSealedRecordXL
    [Benchmark]
    public int AllocateSealedRecordXL()
    {
        var list = new List<PointSealedRecordXL>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointSealedRecordXL(Guid.Empty, Guid.Empty, "A", "B", 1m, 2m,
                i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i));
        return list.Count;
    }
    #endregion

    #region AllocateStructXL
    [Benchmark]
    public int AllocateStructXL()
    {
        var list = new List<PointStructXL>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointStructXL(Guid.Empty, Guid.Empty, "A", "B", 1m, 2m,
                i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i));
        return list.Count;
    }
    #endregion

    #region AllocateReadonlyStructXL
    [Benchmark]
    public int AllocateReadonlyStructXL()
    {
        var list = new List<PointReadonlyStructXL>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointReadonlyStructXL(Guid.Empty, Guid.Empty, "A", "B", 1m, 2m,
                i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i));
        return list.Count;
    }
    #endregion

    #region AllocateRecordStructXL
    [Benchmark]
    public int AllocateRecordStructXL()
    {
        var list = new List<PointRecordStructXL>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointRecordStructXL(Guid.Empty, Guid.Empty, "A", "B", 1m, 2m,
                i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i));
        return list.Count;
    }
    #endregion

    #region AllocateReadonlyRecordStructXL
    [Benchmark]
    public int AllocateReadonlyRecordStructXL()
    {
        var list = new List<PointReadonlyRecordStructXL>(Count);
        for (int i = 0; i < Count; i++)
            list.Add(new PointReadonlyRecordStructXL(Guid.Empty, Guid.Empty, "A", "B", 1m, 2m,
                i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i, i));
        return list.Count;
    }
    #endregion
    
    #endregion
}
