Shader "Unlit/StencilFilter2"
{
    Properties
    {
        _Color("Color",Color)=(1,1,1,1)
		[Enum(Equal,3,NotEqual,6)] _StencilTest ("Stencil Test",int)=6
		_RefValue("RefValue",int)=2
		_OriRefValue("RefValue",int) = 2
    }
    SubShader
    {
       Color [_Color]
	   Stencil{
		Ref[_RefValue]
		Comp [_StencilTest]
		}

        Pass
        {
            
        }
    }
}
