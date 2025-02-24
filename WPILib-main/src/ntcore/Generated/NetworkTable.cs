// Copyright (c) FIRST and other WPILib contributors.
// Open Source Software; you can modify and/or share it under the terms of
// the WPILib BSD license file in the root directory of this project.

// THIS FILE WAS AUTO-GENERATED BY ./ntcore/generate_topics.py. DO NOT MODIFY

namespace NetworkTables;

public sealed partial class NetworkTable
{
    /// <summary>
    /// Gets a bool topic.
    /// </summary>
    /// <param name="name">topic name</param>
    /// <returns>BooleanTopic</returns>
    public BooleanTopic GetBooleanTopic(string name)
    {
        return Instance.GetBooleanTopic($"{m_pathWithSep}{name}");
    }

    /// <summary>
    /// Gets a long topic.
    /// </summary>
    /// <param name="name">topic name</param>
    /// <returns>IntegerTopic</returns>
    public IntegerTopic GetIntegerTopic(string name)
    {
        return Instance.GetIntegerTopic($"{m_pathWithSep}{name}");
    }

    /// <summary>
    /// Gets a float topic.
    /// </summary>
    /// <param name="name">topic name</param>
    /// <returns>FloatTopic</returns>
    public FloatTopic GetFloatTopic(string name)
    {
        return Instance.GetFloatTopic($"{m_pathWithSep}{name}");
    }

    /// <summary>
    /// Gets a double topic.
    /// </summary>
    /// <param name="name">topic name</param>
    /// <returns>DoubleTopic</returns>
    public DoubleTopic GetDoubleTopic(string name)
    {
        return Instance.GetDoubleTopic($"{m_pathWithSep}{name}");
    }

    /// <summary>
    /// Gets a byte[] topic.
    /// </summary>
    /// <param name="name">topic name</param>
    /// <returns>RawTopic</returns>
    public RawTopic GetRawTopic(string name)
    {
        return Instance.GetRawTopic($"{m_pathWithSep}{name}");
    }

    /// <summary>
    /// Gets a bool[] topic.
    /// </summary>
    /// <param name="name">topic name</param>
    /// <returns>BooleanArrayTopic</returns>
    public BooleanArrayTopic GetBooleanArrayTopic(string name)
    {
        return Instance.GetBooleanArrayTopic($"{m_pathWithSep}{name}");
    }

    /// <summary>
    /// Gets a long[] topic.
    /// </summary>
    /// <param name="name">topic name</param>
    /// <returns>IntegerArrayTopic</returns>
    public IntegerArrayTopic GetIntegerArrayTopic(string name)
    {
        return Instance.GetIntegerArrayTopic($"{m_pathWithSep}{name}");
    }

    /// <summary>
    /// Gets a float[] topic.
    /// </summary>
    /// <param name="name">topic name</param>
    /// <returns>FloatArrayTopic</returns>
    public FloatArrayTopic GetFloatArrayTopic(string name)
    {
        return Instance.GetFloatArrayTopic($"{m_pathWithSep}{name}");
    }

    /// <summary>
    /// Gets a double[] topic.
    /// </summary>
    /// <param name="name">topic name</param>
    /// <returns>DoubleArrayTopic</returns>
    public DoubleArrayTopic GetDoubleArrayTopic(string name)
    {
        return Instance.GetDoubleArrayTopic($"{m_pathWithSep}{name}");
    }
}
