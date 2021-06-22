Shader "Unlit/WhiteFade"
{
	Properties
	{
		_MainTex("Texture", 2D) = "white" {}
		_Clip("_Clip", Range(0, 1)) = 0
	}
		SubShader
		{
			Tags {"RenderType" = "Transparent" "Queue" = "Transparent"}
			Blend SrcAlpha OneMinusSrcAlpha
			LOD 200

			Pass
			{
				CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag

				#include "UnityCG.cginc"

				struct appdata
				{
					float4 vertex : POSITION;
					float2 uv : TEXCOORD0;
				};

				struct v2f
				{
					float2 uv : TEXCOORD0;
					float4 vertex : SV_POSITION;
				};

				sampler2D _MainTex;
				float4 _MainTex_ST;
				float _Clip;

				v2f vert(appdata v)
				{
					v2f o;
					o.vertex = UnityObjectToClipPos(v.vertex);
					o.uv = TRANSFORM_TEX(v.uv, _MainTex);
					return o;
				}

				fixed4 frag(v2f i) : SV_Target
				{
					// sample the texture
					fixed4 col = fixed4(1, 1, 1, 1);
					fixed fade = tex2D(_MainTex, i.uv).r;
					col.a = fade + 1 - _Clip*2;
					// float clip = _Clip;

					if (col.a < 0)
					{
						discard;
					}


					return col;
				}
				ENDCG
			}
		}
}
