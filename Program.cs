/*  Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 *  C.S.T. em Análise e Desenvolvimento de Sistemas
 *  Disciplina de Algoritmo e Lógica de Programação II
 *  Professor Clayton Ferraz de Andrade
 *  
 *  Acadêmico Vinicius de Oliveira Pinheiro
 *  Aula do dia 28-08-2023
 *  - Atividade n. 02 de ALP II - Matrizes 
 *  - Exercício pedido em sala
 */
void Presentation()
{
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(@"


   ----------------------------------------------------------------------    
   Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
   ----------------------------------------------------------------------
   
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++      +++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++++.....+++      ++        +++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++

          --------------------------------------------------------
          C.S.T. em Análise e Desenvolvimento de Sistemas
          Disciplina de Algoritmo e Lógica de Programação II
          --------------------------------------------------------
          ");
        Console.ReadLine();
        Console.Clear();
    }
}
void Exercise01()
{
    Console.WriteLine(@"



        ========== CADASTRO DE ALUNOS ==========

        Este algoritmo faz o cadastro de um número de alunos, 
        de quantas disciplinas eles cursam, quais elas são, e
        qual foi a nota em cada uma delas.");
    Console.Clear();
    Console.Write("\n\n\n\n        Quantos alunos deseja cadastrar? ");
    int howManyStudents = Convert.ToInt32(Console.ReadLine()); // para definir o número de alunos

    string[] studentName = new string[howManyStudents];
    int[] subjectsNumber = new int[howManyStudents];
    double[][] subjectsGrade = new double[howManyStudents][];
    string[][] schoolSubject = new string[howManyStudents][];

    for (int i = 0; i < howManyStudents; i++)
    {
        Console.Clear();
        Console.Write($"\n\n\n\n        Digite o nome do {i + 1}º aluno: ");
        studentName[i] = Console.ReadLine()!;
        
        Console.Write($"        Quantas disciplinas {studentName[i]} cursa? ");
        subjectsNumber[i] = Convert.ToInt32(Console.ReadLine());
        
        schoolSubject[i] = new string[subjectsNumber[i]];
        subjectsGrade[i] = new double[subjectsNumber[i]];
        
        for (int j = 0; j < subjectsNumber[i]; j++)
        {
            Console.Write($"\n        Qual é o nome da {j + 1}ª matéria que {studentName[i]} cursa? ");
            schoolSubject[i][j] = Console.ReadLine()!;
            Console.Write($"        Digite a nota de {studentName[i]} em {schoolSubject[i][j]}: ");
            subjectsGrade[i][j] = Convert.ToDouble(Console.ReadLine()); 
        }
        Console.Clear();
    }
    Console.Clear();
    Console.Write("\n\n\n\n        Loading...");
    for (int i = 0; i < 25; i++)
    {
        System.Threading.Thread.Sleep(30);
        Console.Write(".");
    }
    for (int i = 0; i < howManyStudents; i++)
    {
        if (i == 0)
        {
            Console.WriteLine($"\n\n\n\n        O nome do {i + 1}º aluno é {studentName[i]}.\n        {studentName[i]} estuda {subjectsNumber[i]} disciplinas.");
            for (int j = 0; j < subjectsNumber[i]; j++)
            {
                Console.WriteLine($"        A nota de {studentName[i]} em {schoolSubject[i][j]} é: {subjectsGrade[i][j]}.");
            }
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine($"\n        O nome do {i + 1}º aluno é {studentName[i]}.\n        {studentName[i]} estuda {subjectsNumber[i]} disciplinas.");
            for (int j = 0; j < subjectsNumber[i]; j++)
            {
                Console.WriteLine($"        A nota de {studentName[i]} em {schoolSubject[i][j]} é: {subjectsGrade[i][j]}.");
            }
        }
    }
    Console.ReadLine();
}
void Exercise02()
{
    Console.WriteLine(@"



        ========== CADASTRO DE FAZENDEIROS ==========

        Este algoritmo faz o cadastro de um número de fazendeiros, 
        de quantos tipos de gados eles possuem, quais são os tipos,
        e qual é o valor unitário de cada tipo.");
    Console.Clear();
    Console.Write("\n\n\n\n        Quantos fazendeiros você deseja registrar? ");
    int farmerNumber = Convert.ToInt32(Console.ReadLine());
    string[] farmerName = new string [farmerNumber];
    int[] livestockCount = new int [farmerNumber];
    string[][] kindOfLivestock = new string[farmerNumber][];
    double[][] oneAnimalsWorth = new double[farmerNumber][];
    Console.Clear();
    for (int i = 0; i < farmerNumber; i++)
    {
        Console.Write($"\n\n\n\n        Qual é o nome do {i+1}º fazendeiro? ");
        farmerName[i] = Console.ReadLine()!;
        Console.Write($"        Quantos tipos de gado {farmerName[i]} possui? ");
        livestockCount[i] = Convert.ToInt32(Console.ReadLine());

        kindOfLivestock[i] = new string[livestockCount[i]];
        oneAnimalsWorth[i] = new double[livestockCount[i]];
        for(int j = 0; j < livestockCount[i];j++) 
        {
            Console.Write($"        Qual é o {j + 1}º tipo de gado que {farmerName[i]} possui? ");
            kindOfLivestock[i][j] = Console.ReadLine()!;
            Console.Write($"        Qual é o valor deste {j + 1}º tipo de gado? ");
            oneAnimalsWorth[i][j] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
        }
        Console.Clear();
    }
    Console.Write("\n\n\n\n        Loading...");
    for (int i = 0; i < 25; i++)
    {
        System.Threading.Thread.Sleep(30);
        Console.Write(".");
    }
    for (int i = 0; i < farmerNumber; i++)
    {
        if (i == 0)
        {
            Console.WriteLine($"\n\n\n\n        O nome do {i + 1}º fazendeiro é {farmerName[i]}.\n        {farmerName[i]} possui {livestockCount[i]} tipos de animais.");
            for (int j = 0; j < livestockCount[i]; j++)
            {
                Console.WriteLine($"        {farmerName[i]} possui {kindOfLivestock[i][j]}s, cujo valor unitário é: {oneAnimalsWorth[i][j].ToString("C2")}");
            }
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine($"\n        O nome do {i + 1}º fazendeiro é {farmerName[i]}.\n        {farmerName[i]} possui {livestockCount[i]} tipos de animais.");
            for (int j = 0; j < livestockCount[i]; j++)
            {
                Console.WriteLine($"        {farmerName[i]} possui {kindOfLivestock[i][j]}s, cujo valor unitário é: {oneAnimalsWorth[i][j].ToString("C2")}.");
            }
            Console.WriteLine("");
        }
    }
    Console.ReadLine();
}
void Atividade02_ALPII()
{
    Presentation();
    while (true)
    {
        Console.Clear();
        Console.Write(@"


 
          C.S.T. em Análise e Desenvolvimento de Sistemas
          Disciplina de Algoritmo e Lógica II
          Professor Clayton Ferraz de Andrade
          -----------------------------------------------
          Acadêmico Vinícius de Oliveira Pinheiro
          -----------------------------------------------
          Atividade 02 - Exercícios para fixação - Matriz 
    
          Exercício [01] - Cadastro de alunos, suas disciplinas e notas;
          Exercício [02] - Cadastro de fazendeiros, seu gado e o preço;

          Qual exercício gostaria de verificar? ");
        int exercise = int.Parse(Console.ReadLine()!);
        Console.Clear();
        switch (exercise)
        {
            case 1 or 01: Exercise01(); break;
            case 2 or 02: Exercise02(); break;

            default:
                Console.Clear();
                Console.WriteLine("        Desculpa, eu não entendi. Poderia repetir?");
                break;
        }
        Console.Clear();
        Console.Write("\n\n\n\n        Selecionar outro exercício ou encerrar?");
        Console.WriteLine("\n        Se deseja encerrar, digite 'sair'.\n");
        string uscita = Console.ReadLine()!.ToLower();
        if (uscita == "sair")
        {
            break;
        }
        Console.Clear();
    }
}
Atividade02_ALPII();


void Exercise02_AlternativeVersion()
{
    int quantosFazendeiros;
    string[] nomeDoFazendeiro;
    int[] quantosTiposDeGado;
    string[][] tiposDeGado;
    double[][] valorCabeça;
    Console.Write("Quantos fazendeiros você quer registrar? ");
    quantosFazendeiros = int.Parse(Console.ReadLine());
    nomeDoFazendeiro = new string[quantosFazendeiros];
    quantosTiposDeGado = new int[quantosFazendeiros];
    tiposDeGado = new string[quantosFazendeiros][];
    valorCabeça = new double[quantosFazendeiros][];
    for (int i = 0; i < quantosFazendeiros; i++)
    {
        Console.Write($"Qual é o nome do {i + 1}º fazendeiro? ");
        nomeDoFazendeiro[i] = Console.ReadLine()!;
        Console.Write($"Quantos tipos de gado {nomeDoFazendeiro[i]} possui? ");
        quantosTiposDeGado[i] = int.Parse(Console.ReadLine());

        tiposDeGado[i] = new string[quantosTiposDeGado[i]];
        valorCabeça[i] = new double[quantosTiposDeGado[i]];
        for (int j = 0; j < quantosTiposDeGado[i]; j++)
        {
            Console.Write($"Qual é o {j + 1}º tipo de gado que {nomeDoFazendeiro[i]} possui? ");
            tiposDeGado[i][j] = Console.ReadLine()!;
            Console.Write($"Qual é o valor deste {j + 1}º tipo de gado? ");
            valorCabeça[i][j] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
        }  
    }
    for (int i = 0; i < quantosFazendeiros; i++)
    {
       
       Console.WriteLine($"O nome do {i + 1}º fazendeiro é {nomeDoFazendeiro[i]}.");
       Console.WriteLine($"{nomeDoFazendeiro[i]} possui {quantosTiposDeGado[i]} tipos de gado.\");");
            
       for (int j = 0; j < quantosTiposDeGado[i]; j++)
       {
            Console.WriteLine($"{nomeDoFazendeiro[i]} possui {tiposDeGado[i][j]}s, cujo valor unitário é: R$ {valorCabeça[i][j]}");
       }
    }
    Console.ReadLine();
}
