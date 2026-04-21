interface MySquareProps {
    size: number;
    text: string;
    backgroundColor?: string;
}

function MySquare({ size, text, backgroundColor = "lightblue" }: MySquareProps) {

    return <div style={
        { width: size, height: size, backgroundColor: backgroundColor, display: "flex", alignItems: "center", justifyContent: "center" }
    }>MySquare! {text}</div>;
}

export default MySquare;
