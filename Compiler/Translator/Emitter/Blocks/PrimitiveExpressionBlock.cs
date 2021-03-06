﻿using Bridge.Contract;
using ICSharpCode.NRefactory.CSharp;

namespace Bridge.Translator
{
    public class PrimitiveExpressionBlock : ConversionBlock
    {
        public PrimitiveExpressionBlock(IEmitter emitter, PrimitiveExpression primitiveExpression)
            : base(emitter, primitiveExpression)
        {
            this.Emitter = emitter;
            this.PrimitiveExpression = primitiveExpression;
        }

        public PrimitiveExpression PrimitiveExpression
        {
            get;
            set;
        }

        protected override Expression GetExpression()
        {
            return this.PrimitiveExpression;
        }

        protected override void EmitConversionExpression()
        {
            if (this.PrimitiveExpression.IsNull)
            {
                return;
            }

            if (this.PrimitiveExpression.Value is RawValue)
            {
                this.Write(this.PrimitiveExpression.Value.ToString());
            }
            else
            {
                this.WriteScript(this.PrimitiveExpression.Value);    
            }
        }
    }
}