 Shader "Unlit/PortalShader5"
{
    
    SubShader
    {
		ZWrite off
		ColorMask 0 
	  Stencil
	  {
		Ref 5
		Pass replace
	  }

        Pass
        {
          
        }
      
        
    }
}
