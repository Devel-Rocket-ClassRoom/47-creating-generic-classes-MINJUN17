using System;
using System.Collections.Generic;
using System.Text;

class Converter<TInput, TOutput>
{
    private Func<TInput, TOutput> _converter;
    public Converter(Func<TInput, TOutput> converter)
    {
        _converter = converter;
    }
    public TOutput Convert(TInput input)
    {
        return _converter(input);
    }
    public TOutput[] ConvertAll(TInput[] inputs)
    {
        TOutput[] convertInputs = new TOutput[inputs.Length];
        for(int i = 0; i < convertInputs.Length; i++)
        {
            convertInputs[i] = _converter(inputs[i]);
        }
        return convertInputs;
    }
}
