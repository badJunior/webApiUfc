import { useState } from "react";

function App() {
  const [count, setCount] = useState(0);

  return (
    <div className="flex size-full items-center justify-center bg-slate-500">
      <div className="flex flex-col gap-2">
        <h1 className="text-5xl font-bold text-center underline">Vite + React</h1>
        <div className="flex flex-col gap-1">
          <button className="bg-slate-800 h-[40px] text-white w-[300px] hover:bg-slate-900 active:bg-slate-950 rounded-md" onClick={() => setCount((count) => count + 1)}>
            count is {count}
          </button>
          <p>
            Edit <code>src/App.tsx</code> and save to test HMR
          </p>
        </div>
      </div>
    </div>
  );
}

export default App;
