using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class ReflectionProbeParam : MonoBehaviour
{
    ReflectionProbe m_ReflProbe;

    [Header("Reflection Probe ���ĵ�")]
    public Vector3 reflProbeCenter;

    [Header("Reflection Probe ��ײBox����С��")]
    public Vector3 reflProbeBoxMin;

    [Header("Reflection Probe ��ײBox������")]
    public Vector3 reflProbeBoxMax;

    // Start is called before the first frame update
    void Start()
    {
        m_ReflProbe = GetComponent<ReflectionProbe>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_ReflProbe != null)
        {
            reflProbeCenter = m_ReflProbe.bounds.center;
            reflProbeBoxMin = m_ReflProbe.bounds.min;
            reflProbeBoxMax = m_ReflProbe.bounds.max;
        }
    }
}
