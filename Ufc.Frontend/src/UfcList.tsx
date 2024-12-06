import { useMutation, useQueryClient } from "@tanstack/react-query";
import FightersList from "./FightersList";
import WinnersList from "./WinnersList";
import BestWinnersList from "./BestWinnersList";  

function UfcList() {
  const queryClient = useQueryClient();
  const mutation = useMutation({
    mutationFn: () =>
      fetch("http://localhost:5242/cards", {
        method: "POST",
      }
    ),
    onSuccess: () => {
      // Invalidate and refetch
      queryClient.invalidateQueries({ queryKey: ["winners"], exact: false });
      queryClient.invalidateQueries({ queryKey: ["bestWinners"], exact: false });
    

    },


  });
  
  return (
    <div className="flex size-full justify-center bg-slate-500 h-full">
      <div className="flex flex-col   gap-2  w-[30%] h-full  overflow-hidden">
        <h1 className="text-5xl font-bold text-center underline">UFC</h1>
       
        <div className=" grid grid-rows-[auto,auto,1fr] gap-2 w-full overflow-hidden">
        <BestWinnersList/>

          <button
            onClick={() => mutation.mutate()}
            className="bg-slate-600 rounded-lg hover:bg-slate-800 active:bg-slate-900 h-9"

          >
            Make card
          </button>

        <div className="grid grid-cols-2 gap-2 h-full ">
        
        <FightersList /> 
        <WinnersList />
        </div>
        </div>
      </div>
    </div>

  );
}

export default UfcList;
